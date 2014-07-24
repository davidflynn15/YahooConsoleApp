using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
//using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
//using System.Threading.Tasks;

namespace YahooConsoleApp
{
    class Program
    {
        public class YahooStockQuote
        {
            public string symbol { get; set; }
            public string AverageDailyVolume { get; set; }
            public string Change { get; set; }
            public string DaysLow { get; set; }
            public string DaysHigh { get; set; }
            public string YearLow { get; set; }
            public string YearHigh { get; set; }
            public string MarketCapitalization { get; set; }
            public string LastTradePriceOnly { get; set; }
            public string DaysRange { get; set; }
            public string Name { get; set; }
            public string Symbol { get; set; }
            public string Volume { get; set; }
            public string StockExchange { get; set; }
        }

        public class Investment
        {
            public string TickerSymbol { get; set; }
            public string FullName { get; set; }
            public string AccountType { get; set; }     //Roth, IRA, or Regular
            public string NumberShares { get; set; }    //xxx.nnn
            public string ShareValue { get; set; }
            public string MarketValue { get; set; }
            public string CostBasis { get; set; }
            public string GainLoss { get; set; }
            public string PercentGainLoss { get; set; }
            public string InvestmentType { get; set; }  //s - stock, mf - mutual fund
            public string MFType { get; set; }          //Large, Mid, Small, International, Global
        }

        static void Main(string[] args)
        {
            ////this is working
            //StringBuilder webAddress = new StringBuilder();
            
            ////get the quote data
            //webAddress.Append("http://query.yahooapis.com/v1/public/yql?");
            //webAddress.Append("q=select%20*%20from%20yahoo.finance.quote%20where%20symbol%20in%20('YHOO','AAPL','GOOG','MSFT')");
            //webAddress.Append("&format=json");
            //webAddress.Append("&diagnostics=false&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys&callback=");
            
            //using (WebClient wc = new WebClient())
            //{
            //    //var results = wc.DownloadString(webAddress.ToString());
            //    string yResults = @"{'query':{'count':4,'created':'2014-07-12T02:58:53Z','lang':'en-US','results':{'quote':[{'symbol':'YHOO','AverageDailyVolume':'19965500','Change':'+0.50','DaysLow':'34.78','DaysHigh':'35.56','YearLow':'26.73','YearHigh':'41.72','MarketCapitalization':'35.671B','LastTradePriceOnly':'35.43','DaysRange':'34.78 - 35.56','Name':'Yahoo! Inc.','Symbol':'YHOO','Volume':'18379520','StockExchange':'NasdaqNM'},{'symbol':'AAPL','AverageDailyVolume':'65380500','Change':'+0.185','DaysLow':'94.8625','DaysHigh':'95.89','YearLow':'59.8157','YearHigh':'96.80','MarketCapitalization':'574.1B','LastTradePriceOnly':'95.22','DaysRange':'94.8625 - 95.89','Name':'Apple Inc.','Symbol':'AAPL','Volume':'34018228','StockExchange':'NasdaqNM'},{'symbol':'GOOG','AverageDailyVolume':'1959220','Change':'+8.08','DaysLow':'571.42','DaysHigh':'580.85','YearLow':'502.80','YearHigh':'604.83','MarketCapitalization':'390.7B','LastTradePriceOnly':'579.18','DaysRange':'571.42 - 580.85','Name':'Google Inc.','Symbol':'GOOG','Volume':'1617569','StockExchange':'NasdaqNM'},{'symbol':'MSFT','AverageDailyVolume':'27950300','Change':'+0.405','DaysLow':'41.48','DaysHigh':'42.09','YearLow':'30.84','YearHigh':'42.29','MarketCapitalization':'347.7B','LastTradePriceOnly':'42.09','DaysRange':'41.48 - 42.09','Name':'Microsoft Corpora','Symbol':'MSFT','Volume':'24087374','StockExchange':'NasdaqNM'}]}}}";

            //    //see Serializing partial json fragments
            //    //Console.WriteLine(results);
            //    JObject yahooSearch = JObject.Parse(yResults);
            //    IList<JToken> results = yahooSearch["query"]["results"]["quote"].Children().ToList();

            //    IList<YahooStockQuote> yahooStockQuotes = new List<YahooStockQuote>();
            //    foreach(JToken result in results)
            //    {
            //        YahooStockQuote ysq = JsonConvert.DeserializeObject<YahooStockQuote>(result.ToString());
            //        yahooStockQuotes.Add(ysq);
            //    }

            //}

            List<Investment> Investments = new List<Investment>();
            Investments = Program.GetInvestment();

            //keep window open
            Console.Read();
        }
                
        public static List<Investment> GetInvestment()
        {
            List<Investment> items = new List<Investment>();

            //get the path of the json file
            string path = Directory.GetCurrentDirectory();
            path += @"\Data\investments.json";

            if (File.Exists(path))
            {
                string data = string.Empty;
                data = File.ReadAllText(path);

                //parse the data
                JsonTextReader reader = new JsonTextReader(new StringReader(data));
                while (reader.Read())
                {

                }
            }
            
            return items;
        }

        public static bool SaveInvestment()
        {
            bool result = false;
            //open file

            //read it

            //populate items

            //

            return result;
        }

    }
}
