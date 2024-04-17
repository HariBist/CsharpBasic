// Random dice = new Random();

// int roll1= dice.Next(1,7);
// int roll2 = dice.Next(1,7);
// int roll3 = dice.Next(1,7);

// int total = roll1 + roll2 +roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3}= {total}");

// if((roll1==roll2)||(roll2==roll3)||(roll1==roll3)){
// Console.WriteLine("You rolled doubles! +2 bonus to total!");
// total +=2;
// }
// if((roll1==roll2)&&(roll2==roll3))
// {
//     Console.WriteLine("you rolled triple!! +6 bounus");
//     total +=6;
// }
// if(total>14)
// {
//     Console.WriteLine("You Win!");
// }
// if(total<15)
// {
//     Console.WriteLine("sorry, you lose.");
// }
// String message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("hari");
// Console.WriteLine(result);
// if(message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }
// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage =0;
// Console.WriteLine(daysUntilExpiration);
// if(daysUntilExpiration==0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if(daysUntilExpiration==1){
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage=20;
// }

//     if(daysUntilExpiration<=5)
//     {
//         Console.WriteLine($"Your suscritption expires in {daysUntilExpiration} days");
//         discountPercentage =10;
//     }
//     else if(daysUntilExpiration<=10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }
// if(discountPercentage>0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%");
// }

// int[] num = new int[3];
// num[0]=3;
// num[2]=4;
// num[1]=5;
string[] names = {"asmita","susmita","dipa","lokendra","hari"};

foreach(string name in names)
{
    if(name.Contains("i"))
    {
        Console.WriteLine($"name:{name}");
    }
}
