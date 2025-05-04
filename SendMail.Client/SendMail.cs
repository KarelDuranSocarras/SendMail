using SendMail.Logic.Implementation;

namespace SendMail.Client
{
    internal class SendMail
    {
        static void Main(string[] args)
        {
            SendService.Send("tucorreo@gmail.com", "tuclave", "destino@gmail.com", "asunto del correo", "contenido del correo");
        }
    }
}
