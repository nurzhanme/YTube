using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using YTube.Models;

using Google.Apis.Auth.OAuth2;
using Google.Apis.YouTube.v3;
using Google.Apis.Services;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Util.Store;

namespace YTube.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Authorize()
        {
            return Ok();
        }

        //private void Authorize()
        //{
        //    // Create the authorization code flow.
        //    var flow = CreateAuthorizationCodeFlow();

        //    // Generate the URL to redirect the user to the Google consent page.
        //    string url = flow.CreateAuthorizationCodeRequest().Build();

        //    // Redirect the user to the Google consent page.
        //    Response.Redirect(url);
        //}

        //private static GoogleAuthorizationCodeFlow CreateAuthorizationCodeFlow()
        //{
        //    // Replace these values with your own client ID and secret.
        //    string clientId = "YOUR_CLIENT_ID";
        //    string clientSecret = "YOUR_CLIENT_SECRET";

        //    // Set the redirect URL to the URL of your application.
        //    string redirectUrl = "http://localhost:12345/Authorize";

        //    // Set the scope to request access to the YouTube Data API.
        //    string[] scopes = new string[] { YouTubeService.Scope.Youtube };

        //    // Create the authorization code flow with the client ID, client secret, and redirect URL.
        //    var flow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
        //    {
        //        ClientSecrets = new ClientSecrets
        //        {
        //            ClientId = clientId,
        //            ClientSecret = clientSecret
        //        },
        //        Scopes = scopes,
        //        DataStore = new FileDataStore("YouTubeAPI"),
        //        RedirectUri = redirectUrl
        //    });

        //    return flow;
        //}

        //private void AuthorizeCallback(string code)
        //{
        //    // Create the authorization code flow.
        //    var flow = CreateAuthorizationCodeFlow();

        //    // Exchange the authorization code for an access token.
        //    var tokenResponse = flow.ExchangeCodeForTokenAsync(
        //        "user", code, "http://localhost:12345/Authorize", CancellationToken.None).Result;
        //}

    }
}