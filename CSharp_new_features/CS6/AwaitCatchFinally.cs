using System;
using System.Threading.Tasks;

namespace CSharp_new_features
{
    class AwaitCatchFinally
    {
        static async void ProcessDataAsync()
        {
            try
            {
                await Task.Delay(5000); // This was already possible
            }
            catch (Exception exception)
            {
                await Task.Delay(5000); // This is new
            }
            finally
            {
                await Task.Delay(5000); // This is new
            }
        }
    }
}
