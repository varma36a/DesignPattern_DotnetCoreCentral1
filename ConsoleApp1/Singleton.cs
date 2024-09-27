using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class ConnectionPool1
    {
        // Step 3: Declare a private static instance(lazy initialization)
        private static ConnectionPool1 _instance = null;
        private static readonly object _lock = new object();

        // Step 1: Private constructor to prevent instantiation from outside
        private ConnectionPool1()
        {
            // Initialize connection pool here
        }

        // Step 2: Public static method to get the singleton instance
        public static ConnectionPool1 GetInstance()
        {
            // Step 4: Double-checked locking to ensure thread safety
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ConnectionPool1();
                    }
                }
            }

            return _instance;
        }
    }

    public class ConnectionPool2
    {
        // Using Lazy<T> for thread-safe lazy initialization
        private static readonly Lazy<ConnectionPool2> _instance =
            new Lazy<ConnectionPool2>(() => new ConnectionPool2());

        // Private constructor to prevent instantiation
        private ConnectionPool2()
        {
            // Initialize connection pool here
        }

        // Public property to provide access to the singleton instance
        public static ConnectionPool2 Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }


    public sealed class ConnectionPool3
    {
        // Static constructor ensures lazy initialization
        private static readonly ConnectionPool3 _instance = new ConnectionPool3();

        // Private constructor to prevent instantiation
        private ConnectionPool3()
        {
            // Initialize connection pool here
        }

        // Public property to provide access to the instance
        public static ConnectionPool3 Instance
        {
            get
            {
                return _instance;
            }
        }
    }




}
