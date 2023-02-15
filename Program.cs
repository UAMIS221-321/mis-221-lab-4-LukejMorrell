//GetFull() x
//GetPartial() x
//while loop x
//nested loop x

//start
//start main 
         {
        while (true) {
            System.Console.WriteLine("Enter 1 for a full triangle, 2 for a partial triangle, or 3 to exit:");
            string input = Console.ReadLine();
            int input1;

            if (int.TryParse(input, out input1)) {
                if (input1 == 1) {
                    GetFull();
                } else if (input1 == 2) {
                    GetPartial();
                } else if (input1 == 3) {
                   System.Console.WriteLine("Program Exit...");
                    break;
                } else {
                    System.Console.WriteLine("Invalid Input");
                }

            } 

        }

    }

// end main

// Start Getfull

    static void GetFull() {
        System.Console.WriteLine();
        Random random = new Random();
        int rows = random.Next(3, 9);
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j <= i; j++) {
                Console.Write("O");
            }
            System.Console.WriteLine();
        }

    }


//end GetFull

//start GetPartial

    static void GetPartial() {
        System.Console.WriteLine();
        Random random = new Random();
        int rows = random.Next(3, 9);
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j <= i; j++) {
                if (random.Next(2) == 0) {
                    Console.Write("O");
                } else {
                    Console.Write(" ");
                }
            }
            System.Console.WriteLine();
        }

    }


//end GetPartial
//end