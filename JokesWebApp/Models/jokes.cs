namespace JokesWebApp.Models
{
    public class jokes
    {
        public int id  { get; set; }
        public string Autor { get; set; }
        public string jokesPergunta  { get; set; }
        public string JokeResposta { get; set; }

        public jokes()
        {
            id = 0;
            Autor = string.Empty;
            jokesPergunta = string.Empty;
            JokeResposta = string.Empty;
              
        }


    }
}
