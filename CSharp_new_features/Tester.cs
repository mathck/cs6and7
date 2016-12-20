using static System.Console;

namespace CSharp_new_features
{
    public class Tester
    {
        public static void Main()
        {
            WriteLine(NameofExpressions.sample());

            int binaryData = 0B0010_0111_0001_0000; // binary value of 10000   
            int hexaDecimalData = 0X2B_67;          // HexaDecimal Value of 11,111   
            int decimalData = 104_567_789;
            int myCustomData = 1___________2__________3___4____5_____6;
            double realdata = 1_000.111_1e1_00;
            WriteLine($" binaryData :{binaryData} \n hexaDecimalData: {hexaDecimalData} \n decimalData: {decimalData} \n myCustomData: {myCustomData} \n realdata: {realdata}");
            ReadLine();
        }
    }
}
