using System.Drawing;

namespace SlotMachine.Models
{
    public abstract class Theme
    {
        public abstract string[] Symbols { get; }
        public abstract Font Font { get; }
        public abstract Color Color { get; }
    }
    public class FruitTheme : Theme
    {
        public override string[] Symbols => new string[]
        {
            "Images/cherry.png",
            "Images/banana.png",
            "Images/blue.png",
            "Images/greenapple.png",
            "Images/grapes.png",
            "Images/orange.png",
            "Images/redgrapes.png",
            "Images/watermelon.png"
        };

        public override Font Font => new Font("Arial", 12);
        public override Color Color => Color.Red;
    }

    public class AnimalTheme : Theme
    {
        public override string[] Symbols => new string[]
        {
            "Animals/penguin.png",
            "Animals/tiger.png",
            "Animals/elephant.png",
            "Animals/monkey.png",
            "Animals/giraffe.png",
            "Animals/dog.png",
            "Animals/racoon.png",
            "Animals/cat.png",
            "Animals/wolf.png",
        };

        public override Font Font => new Font("Comic Sans MS", 12);
        public override Color Color => Color.Green;
    }

    public class JewelTheme : Theme
    {
        public override string[] Symbols => new string[]
        {
            "Jewels/diamond.png",
            "Jewels/blue.png",
            "Jewels/circle.png",
            "Jewels/green.png",
            "Jewels/purple.png",
            "Jewels/pyramid.png",
            "Jewels/red.png",
            "Jewels/triangle.png",
            "Jewels/yellow.png",
            "Jewels/ygreen.png"
        };

        public override Font Font => new Font("Times New Roman", 12);
        public override Color Color => Color.Blue;
    }
    public class NumberTheme : Theme
    {
        public override string[] Symbols => new string[]
        {
            "Numbers/one.png",
            "Numbers/two.png",
            "Numbers/three.png",
            "Numbers/four.png",
            "Numbers/five.png",
            "Numbers/six.png",
            "Numbers/seven.png",
            "Numbers/eight.png",
            "Numbers/nine.png",
            "Numbers/zero.png"

        };

        public override Font Font => new Font("Courier New", 12);
        public override Color Color => Color.Black;
    }
}