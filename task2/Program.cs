int w = Convert.ToInt32(Console.ReadLine());
int h = Convert.ToInt32(Console.ReadLine());
Rectangle rectangle = new Rectangle();
rectangle.width = w;
rectangle.height = h;
System.Console.WriteLine(rectangle.Area());
class Rectangle {
    int ar = 0;
        public int width;
        public int height;
        public int Area()
        {
            ar = width * height;
            return  ar;
        }
    }