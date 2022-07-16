using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        public List<Stock> Portfolio;
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
            Portfolio = new List<Stock>();
        }

        public int Count => Portfolio.Count;
        
        public void BuyStock(Stock stock)
        {          
            if (stock.MarketCapitalization > 10000 && this.MoneyToInvest >= stock.PricePerShare)
            {
                Portfolio.Add(stock);
                MoneyToInvest -= stock.PricePerShare;
            }
        }
        public string SellStock(string companyName, decimal sellPrice)
        {
            if (!Portfolio.Any(x => x.CompanyName == companyName))
            {
                return $"{companyName} does not exist.";
            }

            Stock stockToSell = Portfolio.Where(x => x.CompanyName == companyName).First();

            if (sellPrice < stockToSell.PricePerShare)
            {
                return $"Cannot sell {companyName}.";
            }

            Portfolio.Remove(stockToSell);
            MoneyToInvest += sellPrice;
            return $"{companyName} was sold.";
        }

        public Stock FindStock(string companyName)
        {
            return Portfolio.Where(x => x.CompanyName == companyName).FirstOrDefault();
        }

        public Stock FindBiggestCompany()
        {
            return Portfolio.OrderByDescending(x => x.MarketCapitalization).FirstOrDefault();
        }

        public string InvestorInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks:");
            foreach (var item in Portfolio)
            {
                sb.Append($"{item.ToString()}{Environment.NewLine}");
            }
            return sb.ToString().Trim();
        }
    }
}
