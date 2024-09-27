
using DP11.Prototype;

namespace DP11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var student = new NewStudent.NewStudentBuilder()
                .SetFirstName("John")
                .SetLastName("Doe")
                .SetEmail("john.doe@example.com")
                .SetPhone("123-456-7890")
                .SetAddress("123 Main St")
                .Build();

            Console.WriteLine($"Student Name: {student.FirstName} {student.LastName}");


            // Create prototypes for background and foreground objects
            IGameElement treePrototype = new BackgroundObject("TreeTexture", "Green");
            IGameElement enemyPrototype = new ForegroundObject("Orc", 10);

            // Prototype manager to manage our prototypes
            PrototypeManager prototypeManager = new PrototypeManager();
            prototypeManager.AddPrototype("Tree", treePrototype);
            prototypeManager.AddPrototype("Enemy", enemyPrototype);

            // Clone and use prototypes for background and foreground objects
            IGameElement tree1 = prototypeManager.GetPrototype("Tree");
            IGameElement tree2 = prototypeManager.GetPrototype("Tree");
            IGameElement enemy1 = prototypeManager.GetPrototype("Enemy");

            // Render the cloned objects
            tree1.Render();  // Output: Rendering background object with Texture: TreeTexture, Color: Green
            tree2.Render();  // Output: Rendering background object with Texture: TreeTexture, Color: Green
            enemy1.Render(); // Output: Rendering foreground object (Character: Orc, Speed: 10)



        }
    }
}
