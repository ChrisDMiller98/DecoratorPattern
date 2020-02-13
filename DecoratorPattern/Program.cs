using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//code help from dofactory.com
namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 0;
            int height = 0;
            Widget w;
            TextField tf = new TextField(width, height);
            BorderDecorator bd = new BorderDecorator(w);//?
            ScrollDecorator sd = new ScrollDecorator(w);

            bd.SetComponent(tf);
            sd.SetComponent(tf);

            bd.draw();
            sd.draw();

            Console.ReadKey();
        }
    }

    abstract class Widget
    {
        public abstract void draw();
    }

    class TextField : Widget
    {
        private int width;
        private int height;

        public TextField(int w, int h)
        {
            this.width = w;
            this.height = h;
        }
        public override void draw()
        {
            Console.WriteLine("I am a Text Field ");
        }
    }

    abstract class Decorator : Widget

    {
        //protected Widget w;

        private Widget wid;
        public Decorator(Widget w)
        {
            this.wid = w;
        }
        
        public void SetComponent(Widget w)
        {
            this.wid = w;
        }
        

        public override void draw()
        {
            if (wid != null)
            {
                wid.draw();
            }
        }
    }

    class BorderDecorator : Decorator

    {
        public BorderDecorator(Widget w)
        {

        }
        public override void draw()
        {
            base.draw();
            Console.WriteLine("I am a border decorator, holding a:");
        }
    }

    class ScrollDecorator : Decorator

    {
        public ScrollDecorator(Widget w)
        {

        }
        public override void draw()
        {
            base.draw();
            Console.WriteLine("I am a scroll decorator, holding a:");
        }
    }
}
