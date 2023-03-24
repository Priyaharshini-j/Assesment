namespace ColorChocolates
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int choice =;
            
            if(choice == 1) {
                string color = "";
                int count = "";
                addChocolates(ColorChocolates,count);

            }
            if(choice == 2)
            {
                removeChocolates(count);
            }
            if(choice == 3) { dispenseChocolatesOfColor(); }
            if (choice == 4) {
                dispenseChocolatesOfColor();
            }
            if (choice == 5) { noOfChocolates(); }
            if (choice == 6) { sortChocolateBasedOnCount(); }
            if (choice == 7) { changeChocolateColor(); }
            if (choice == 8) { changeChocolateColorAllOfxCount(); }
            if (choice == 9) { removeChocolateOfColor(); }
            if (choice == 10) { dispenseRainbowChocolates(); }
        }
    }
}
