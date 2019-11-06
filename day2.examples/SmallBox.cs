namespace MyFirstProject.day2.examples
{
    public class SmallBox
    {
        public SmallBox(int width, int length){
            this.width = width;
            this.length = length;
        }
        
        public int width { get; set; }
        public int length { get; set; }
 
        public int CalculateArea()
        {
            return width*length;
        }
    }
}