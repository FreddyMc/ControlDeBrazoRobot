namespace ControlDeBrazo
{
    class Pieza
    {
        public Tamaños Tamaño { get; set; }
        public Colores ColorPieza { get; set; }
        public Formas Forma { get; set; }

        public enum Tamaños
        {
            Chica,Mediana,Grande
        }
        public enum Colores
        {
            Roja,Verde,Azúl
        }
        public enum Formas
        {
            Triangular,Cuadrangular,Redonda,NA
        }
        public override string ToString()
        {
            return string.Format(Tamaño.ToString()+ColorPieza.ToString()+Forma.ToString()); 
        }
    }
}
