int readValidInput() {
    bool flag = false;
    int input;
    do {
        Console.Write("Enter a positive integer: ");
        flag = int.TryParse(Console.ReadLine(), out input) && input >= 0;

        if(!flag) Console.WriteLine("That is not a valid number...");

        Console.WriteLine();
    } while(!flag);

    Console.WriteLine($"You entered {input}");
    return input;
}

int readValidChoice(int numChoices) {
    bool flag = true;
    int choice;
    do {
        Console.Write("Enter a choice: ");
        flag = int.TryParse(Console.ReadLine() ?? "", out choice);
        if (choice < 1 || choice > numChoices) {
            Console.WriteLine($"Enter a choice between 1 and {numChoices}"); 
            flag = false;
        }
    } while(!flag);

    return choice;
}

int num1 = readValidInput();
int num2 = readValidInput();

void addNumbers(int a, int b) {
    int sum = 0;
    try {
        sum = a + b;
        Console.WriteLine($"The sum is: {sum}");
    } catch (OverflowException) {
        Console.WriteLine($"{a} and {b} are too big to contain in \"int\" data type!");
    }
}

void multiplyNumbers(int a, int b) {
    int product = 0;
    try {
        product = a * b;
        Console.WriteLine($"The product is: {product}");
    } catch (OverflowException) {
        Console.WriteLine($"{a} and {b} are too big to contain in \"int\" data type!");
    }
}

void oddOrEven(int a, int b) {
    if (a % 2 == 0) {
        Console.WriteLine($"The number {a} is even");
    } else {
        Console.WriteLine($"The number {a} is odd");
    }

    if (b % 2 == 0) {
        Console.WriteLine($"The number {b} is even");
    } else {
        Console.WriteLine($"The number {b} is odd");
    }
}

void displayRange(int num1, int num2) {
    for (int i = num1; i <= num2; ++i) {
        Console.Write($"{i} ");
    }
}

bool flag = true;
while(flag) {
    Console.WriteLine("Enter you Option (1-5)");
    Console.WriteLine("\t1. Add");
    Console.WriteLine("\t2. Multiply");
    Console.WriteLine("\t3. Odd / Even");
    Console.WriteLine("\t4. Display Range");
    Console.WriteLine("\t5. Exit");

    int choice = readValidChoice(5);

    switch(choice) {
        case 1:
            addNumbers(num1, num2);
            break;
        case 2:
            multiplyNumbers(num1, num2);
            break;
        case 3:
            oddOrEven(num1, num2);
            break;
        case 4:
            displayRange(num1, num2);
            break;
        case 5:
        default:
            flag = false;
            break;
    }
    Console.WriteLine();
}