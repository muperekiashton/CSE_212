public static class TakingTurns {
    public static void Test() {
        // Test 1
        Console.WriteLine("Test 1");
        var players = new Queue<string>();
        players.Enqueue("Bob");
        players.Enqueue("Tim");
        players.Enqueue("Sue");
        int turns = 0;
        while (turns < 10) {
            if (players.Count > 0) {
                var currentPerson = players.Dequeue();
                Console.WriteLine(currentPerson);
                players.Enqueue(currentPerson);
                turns++;
            } else {
                Console.WriteLine("No one in the queue.");
                break;
            }
        }
        Console.WriteLine("---------");

        // Test 2
        Console.WriteLine("Test 2");
        players = new Queue<string>();
        players.Enqueue("Bob");
        players.Enqueue("Tim");
        players.Enqueue("Sue");
        players.Enqueue("Tim");
        players.Enqueue("Geore");
        players.Enqueue("Sue");
        players.Enqueue("George");
        turns = 0;
        while (turns < 13) {
            if (players.Count > 0) {
                var currentPerson = players.Dequeue();
                Console.WriteLine(currentPerson);
                if (currentPerson == "Tim" && turns == 6) {
                    players.Enqueue("George");
                    players.Enqueue("George");
                    players.Enqueue("George");
                }
                turns++;
            } else {
                Console.WriteLine("");
                break;
            }
        }
        Console.WriteLine("---------");

        // Test 3
        Console.WriteLine("Test 3");
        players = new Queue<string>();
        players.Enqueue("Bob");
        players.Enqueue("Tim");
        players.Enqueue("Sue");
        turns = 0;
        while (turns < 10) {
            if (players.Count > 0) {
                var currentPerson = players.Dequeue();
                Console.WriteLine(currentPerson);
                players.Enqueue(currentPerson);
                turns++;
            } else {
                Console.WriteLine("No one in the queue.");
                break;
            }
        }
        Console.WriteLine("---------");

        // Test 4
        Console.WriteLine("Test 4");
        players = new Queue<string>();
        players.Enqueue("Tim");
        players.Enqueue("Sue");
        turns = 0;
        while (turns < 10) {
            if (players.Count > 0) {
                var currentPerson = players.Dequeue();
                Console.WriteLine(currentPerson);
                if (currentPerson == "Sue")
                    players.Enqueue(currentPerson);
                turns++;
            } else {
                Console.WriteLine("No one in the queue.");
                break;
            }
        }
        Console.WriteLine("---------");

        // Test 5
        Console.WriteLine("Test 5");
        players = new Queue<string>();
        try {
            var currentPerson = players.Dequeue();
            Console.WriteLine(currentPerson);
        } catch (InvalidOperationException ex) {
            Console.WriteLine("Error: " + ex.Message);
        }
        Console.WriteLine("---------");
    }
}