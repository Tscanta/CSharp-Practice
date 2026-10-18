namespace billing
{
    public static class Calculator
    {
        public static double calculateTax(double subTotal, double taxRate=0.08)
        {
            return subTotal * taxRate;
        }
        public static double calculateTotal(double subTotal, double tax)
        {
            return subTotal + tax;
        }
    }
}