using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP11.Prototype
{
    public class BackgroundObject : IGameElement
    {
        public string Texture { get; set; }
        public string Color { get; set; }

        public BackgroundObject(string texture, string color)
        {
            Texture = texture;
            Color = color;
        }

        // Prototype method to clone the object
        public IGameElement Clone()
        {
            return new BackgroundObject(Texture, Color);
        }

        public void Render()
        {
            Console.WriteLine($"Rendering background object with Texture: {Texture}, Color: {Color}");
        }
    }

    // Concrete Prototype 2 - Foreground Object (e.g., Enemy)
    public class ForegroundObject : IGameElement
    {
        public string Character { get; set; }
        public int Speed { get; set; }

        public ForegroundObject(string character, int speed)
        {
            Character = character;
            Speed = speed;
        }

        // Prototype method to clone the object
        public IGameElement Clone()
        {
            return new ForegroundObject(Character, Speed);
        }

        public void Render()
        {
            Console.WriteLine($"Rendering foreground object (Character: {Character}, Speed: {Speed})");
        }
    }
}
