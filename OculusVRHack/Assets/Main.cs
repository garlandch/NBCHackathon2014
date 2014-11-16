using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Collections.Generic;

namespace testhttp
{
	class MainClass
	{
		//Limit to only 1 tweet
		private const String SEARCHPARMS = "&filter.no_profanity=true&filter.start=-10d&filter.finish=0&view.entities.limit=1";
		private const String SPREADFASTAPI = "https://search-proxy.massrelevance.com/search.json?q=";
		private const String FILTER = "&filter.text=";
		private static string[] BUZZWORDS = {"great","awesome","love", "wait", "sick", "sweet", "cool"};

		public static List<string> getFF7Tweets()
		{
			List<string> results = new List<string> ();
			for(int i = 0; i < BUZZWORDS.Length; ++i)
			{
				results.Add(getMovieTweets("furious7",BUZZWORDS[i]));
			}
			return results;
		}

		public static List<string> getPaulWalkerTweets()
		{
			List<string> results = new List<string> ();
			for(int i = 0; i < BUZZWORDS.Length; ++i)
			{
				results.Add(getMovieTweets("paulwalker",BUZZWORDS[i]));
			}
			return results;
		}

		public static List<string> getVinDieselTweets()
		{
			List<string> results = new List<string> ();
			for(int i = 0; i < BUZZWORDS.Length; ++i)
			{
				results.Add(getMovieTweets("vindiesel",BUZZWORDS[i]));
			}
			return results;
		}

		public static List<string> getTheRockTweets()
		{
			List<string> results = new List<string> ();
			for(int i = 0; i < BUZZWORDS.Length; ++i)
			{
				results.Add(getMovieTweets("therock",BUZZWORDS[i]));
			}
			return results;
		}

		public static string getMovieTweets(string searchterm, string buzzword)
		{
			WebRequest request = WebRequest.Create( SPREADFASTAPI + searchterm + FILTER + buzzword + SEARCHPARMS);
			WebResponse response = request.GetResponse();
			Stream dataStream = response.GetResponseStream();
			StreamReader reader = new StreamReader (dataStream);

			string responseFromServer = reader.ReadToEnd ();
			Dictionary<string,string> parsedJson = JsonParsor.JsonParse(responseFromServer);
			string result = parsedJson["text"];
			Console.WriteLine (result);

			reader.Close ();
			response.Close ();
			return result;
		}

	}

}
