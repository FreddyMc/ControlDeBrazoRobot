using System;
using System.Drawing;
using System.Linq;
using AForge.Imaging.Filters;
using System.Drawing.Imaging;
using AForge.Imaging;
using System.Collections.Generic;
using AForge;
using AForge.Math.Geometry;
using System.IO.Ports;
namespace ControlDeBrazo
{
    class Procesar : Pieza
    {


        public static Bitmap EscalaDeGrises(Bitmap pBitmap, int limite = 200)
        {
            Bitmap Salida = new Bitmap(pBitmap.Width, pBitmap.Height);
            //var objectsData = pBitmap.LockBits(new Rectangle(0, 0, pBitmap.Width, pBitmap.Height), ImageLockMode.ReadOnly, pBitmap.PixelFormat);
            //Grayscale grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
            var aux = Grayscale.CommonAlgorithms.BT709.Apply(pBitmap);
            //pBitmap.UnlockBits(objectsData);
            //return aux;
            //
            //Binarización
            //
            var bmplimite = new Threshold(limite).Apply(aux);
            return bmplimite;
        }
        public static bool Piezadetectada(Bitmap Ganterior, Bitmap Gnueva, int limite = 200)
        {
            int cuenta = 0;
            int r = 0;
            Color colorNueva;
            Color colorAnterior;
            for (int x = 0; x < (Ganterior.Width) / 2; x++)
            {
                for (int y = 0; y < Ganterior.Height; y++)
                {
                    colorNueva = Gnueva.GetPixel(x, y);
                    colorAnterior = Ganterior.GetPixel(x, y);
                    r = colorNueva.R - colorAnterior.R;
                    if (r != 0)
                    {
                        cuenta++;
                    }
                }
            }
            return cuenta > limite;
        }
        public static Pieza.Colores DetectarColorDePieza(Bitmap Clon, int desviación = 5)
        {
            
            int[] a = new int[3];
            int[] b = new int[3] { 0, 0, 0 };
            int x = 0;
            int y = 0;
            for ( x = 270; x < 370; x++)
            {
                for ( y = 190; y < 290; y++)
                {
                    a[0] = Clon.GetPixel(x, y).R;
                    a[1] = Clon.GetPixel(x, y).G;
                    a[2] = Clon.GetPixel(x, y).B;
                    var z = (Math.Pow(a[0] - (a.Sum() / 3), 2) + Math.Pow(a[1] - (a.Sum() / 3), 2) + Math.Pow(a[2] - (a.Sum() / 3), 2)) / 3;
                    if (z > desviación)
                    {
                        int o = Array.IndexOf(a, a.Max());
                        b[o]++;
                    }
                }
            }
            int i = Array.IndexOf(b, b.Max());
            return (i == 0) ? Colores.Roja : (i == 1) ? Colores.Verde : Colores.Azúl;
        }
        public static Pieza.Formas detectarForma(Bitmap bitmapG,int wh=15)
        {

            var figura = FindCorners(bitmapG,wh);
            switch (figura)
            {
                case ShapeType.Unknown:
                    return Formas.NA;
                    break;
                case ShapeType.Circle:
                    return Formas.Redonda;
                    break;
                case ShapeType.Triangle:
                    return Formas.Triangular;
                    break;
                case ShapeType.Quadrilateral:
                    return Formas.Cuadrangular;
                    break;
                default:
                    break;
            }

            return Formas.NA;
        }
        public static Pieza.Tamaños DetectarTamaño(Bitmap bitmap, int pTGrande = 1000, int pTMediana = 800)
        {
            int[] a = new int[3];
            int[] b = new int[3] { 0, 0, 0 };
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    a[0] = bitmap.GetPixel(x, y).R;
                    a[1] = bitmap.GetPixel(x, y).G;
                    a[2] = bitmap.GetPixel(x, y).B;
                    var z = (Math.Pow(a[0] - (a.Sum() / 3), 2) + Math.Pow(a[1] - (a.Sum() / 3), 2) + Math.Pow(a[2] - (a.Sum() / 3), 2)) / 3;
                    if (z > 5)
                    {
                        int o = Array.IndexOf(a, a.Max());
                        b[o]++;
                    }
                }
            }
            int i = b.Max();
            return (i > pTGrande) ? Tamaños.Grande : (i > pTMediana) ? Tamaños.Mediana : Tamaños.Chica;
        }
        private static ShapeType FindCorners(Bitmap bitmap,int wh)
        {
            List<IntPoint> corners = new List<IntPoint>();
            using (var clone = bitmap.Clone() as Bitmap)
            {
                new Invert().ApplyInPlace(clone);
                BlobCounter blobCounter = new BlobCounter();
                blobCounter.FilterBlobs = true;
                blobCounter.MinWidth = 15;
                blobCounter.MinHeight = 15;
                blobCounter.ObjectsOrder = ObjectsOrder.Size;
                blobCounter.ProcessImage(clone);
                Blob[] blobs = blobCounter.GetObjectsInformation();
                // create convex hull searching algorithm
                GrahamConvexHull hullFinder = new GrahamConvexHull();
                SimpleShapeChecker checker = new SimpleShapeChecker();
                for (int i = 0, n = blobs.Length; i < n; i++)
                {
                    List<IntPoint> leftPoints, rightPoints;
                    List<IntPoint> edgePoints = new List<IntPoint>();
                    // get blob's edge points
                    blobCounter.GetBlobsLeftAndRightEdges(blobs[i], out leftPoints, out rightPoints);
                    edgePoints.AddRange(leftPoints);
                    edgePoints.AddRange(rightPoints);
                    // blob's convex hull
                    corners = hullFinder.FindHull(edgePoints);
                    var r = checker.CheckShapeType(edgePoints);
                    return r;
                }

            }
            return ShapeType.Unknown;
        }
    }

}
