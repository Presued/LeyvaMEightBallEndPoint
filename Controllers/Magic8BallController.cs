//Manuel L.
//10-27-22
//Magic 8 Ball EndPoint
//The user will be able to ask a question, and the system will throw a random output about
//the question he was asked
//Peer Review: Rafael Manzo, Code works and runs, wonder if tenerary operator would work for this? Great job man, 




using Microsoft.AspNetCore.Mvc;

namespace LeyvaMEightBallEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class Magic8BallController : ControllerBase
{
    [HttpGet]
    [Route("Eight")] 
    public string E(string Text)
    {
        return $" {Text}";
    }


    [HttpGet]
    [Route("Eight/{RNG}")]

    public string J(string RNG)
    {
        int randomNum = 0;
        System.Random r = new System.Random();
        randomNum = r.Next(1, 10);
        string text = "ji";

        switch (randomNum)
        {
            case 1:
                return text = " Try Again ";
                break;

            case 2:
                return text = " Most Defenitly ";
                break;

            case 3:
                return text = " Don't count on it ";
                break;

            case 4:
                return text = " Better not tell you now ";
                break;

            case 5:
                return text = "My reply is no ";
                break;

            case 6:
                return text = " Concentrate and ask again ";
                break;

            case 7:
                return text = " Yes ";
                break;

            case 8:
                return text = " Very doubtful ";
                break;

            case 9:
                return text = " Without a doubt ";
                break;

            case 10:
                return text = " I guess we will never know ";
        }
        return text;
    }

}
