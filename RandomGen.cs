using System;
namespace RandomFromGuid
{
    public class Program
    {
        public static void Main()
        {
            string random=GenerateDoorCode("DealerCode");
        }
        private static string GenerateDoorCode(string whichCode) => whichCode switch
        {
            "DealerCode" => "D:"+new string(Guid.NewGuid().ToString().Where(x=>x >= 48 && x <= 57 ).Take(0..5).ToArray()),
            "CarrierCode" => "C:"+new string(Guid.NewGuid().ToString().Where(x=>x>= 48 && x <= 57 ).Take(0..5).ToArray()),
            _ => throw new ArgumentOutOfRangeException(nameof(whichCode), whichCode, null)
        };
    }
}
