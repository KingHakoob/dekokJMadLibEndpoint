// Jacob Dekok
// 10/25/2022
// MadLib Api
// The user will enter 11 strings
// and the program will insert them into the mad lib
//Peer Review: Brandon Le. Program works properly and all of
// the inputs link to the proper spot in the return. Story was
// not generic andd it was creative. Good job overall. Very nice!


using Microsoft.AspNetCore.Mvc;

namespace dekokJMadLibEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
    [HttpGet]
    [Route("MadLib/{name}/{adj1}/{noun1}/{verb1}/{nounPlural}/{noun2}/{place}/{verb2}/{vehicle}/{adj2}/{noun3}")]

    public string MadLib(string name, string adj1, string noun1, string verb1, string nounPlural, string noun2, string place, string verb2, string vehicle, string adj2, string noun3)
    {

        return $"{name} is a {adj1}  {noun1}. He teaches {verb1} to {nounPlural} who want to learn how. One day his pet {noun2} asks if he wants to go to the {place}. He {verb2} into his {vehicle} and blasts off. Once he gets to the {place}, he gets out of his {vehicle}, and says \"Wow, this place looks like a {adj2} cheese {noun3}.\"";
    }
}
