using System;
using TwitterUCU;

namespace PII_Herencia
{
    /*
        El método Add(Usuario usuario) permite que se puedan agregar más tipos de usuario al programa y puede seguir
        funcionando sin necesidad de que se hagan cambios.
    */
    public class TwitterPoster : IPoster
    {
        public void Add(Usuario usuario)
        {
            Post(usuario.Foto, usuario.MensajePost());
        }

        private void Post(string foto, string mensaje) {
            string consumerKey = "CkovShLMNVCY0STsZlcRUFu99";
            string consumerKeySecret = "6rc35cHCyqFQSy4vIIjKiCYu31qqkBBkSS5BRlqeYCt5r7zO5B";
            string accessTokenSecret = "gNytQjJgLvurJekVU0wmBBkrR1Th40sJmTO8JDhiyUkuy";
            string accessToken = "1396065818-MeBf8ybIXA3FpmldORfBMdmrVJLVgijAXJv3B18";
            var twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitter.PublishToTwitter(mensaje, foto));
        }
    }
}