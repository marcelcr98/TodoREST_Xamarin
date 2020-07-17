using Xamarin.Forms;

namespace TodoREST
{
    public static class Constants
    {
        // URL of REST service 
        //public static string RestUrl = Device.RuntimePlatform == Device.Android ? "https://10.0.2.2:5001/api/todoitems/{0}" : "https://localhost:5001/api/todoitems/{0}";
        //API people Nodejs+Mysql
        public static string RestUrl = "https://xamarin-apis.herokuapp.com/todoapi/api/contact/{0}";
    }
}