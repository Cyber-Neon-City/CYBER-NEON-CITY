using System;

namespace CyberNeonCity.Core
{
    public class GameManager
    {
        private static GameManager instance;

        // Singleton Pattern to ensure only one GameManager exists
        public static GameManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameManager();
                }
                return instance;
            }
        }

        private bool isGameRunning = false;

        public void StartGame()
        {
            isGameRunning = true;
            Console.WriteLine("Game started. Welcome to CYBER NEON CITY!");

            // Initialize core systems
            InputManager.Initialize();
            AIManager.Initialize();

            // Temporary debug message
            Console.WriteLine("Core systems initialized.");
        }

        public void UpdateGame()
        {
            if (!isGameRunning)
                return;

            // Main game loop logic here
            Console.WriteLine("Game is running...");
        }

        public void StopGame()
        {
            isGameRunning = false;
            Console.WriteLine("Game stopped.");
        }
    }
}
