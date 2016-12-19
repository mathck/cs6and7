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
                // foo
            }
            catch (Exception exception)
            {
                await Task.Delay(5000);
            }
            finally
            {
                await Task.Delay(5000);
            }
        }
    }
}
