namespace WebSales.Models
{
    public class SalesProcessor
    {
        private readonly IStockEngine _stockEngine;

        public SalesProcessor(IStockEngine stockEngine)
        {
            _stockEngine = stockEngine;
        }

        public decimal ProcessSale(int sku)
        {
            //init stock
            //List<StockData> stockData = InitStockData();

            //take payment
            //a. lookup cost
            var item = _stockEngine.LookupItem(sku);
            
            var price = item.Cost;

            //real testable logic
            var discountedPrice = (price * 0.75M);
            
            return discountedPrice;

            //b. get payment from user

            //send receipt email
            //SendReceiptEmail(item);
            //log data for internal use
            //update stock database
            //send data to marketing
        }

        //private void SendReceiptEmail(StockData item)
        //{
        //    MailMessage mail = new MailMessage();
            
        //    var smtp = new SmtpClient();
        //    mail.From = new MailAddress("your_email_address@gmail.com");
        //    mail.To.Add("to_address");
        //    mail.Subject = "Test Mail" + item.Description;
        //    mail.Body = "This is for testing SMTP mail from GMAIL";

        //    smtp.Port = 587;
        //    smtp.Credentials = new System.Net.NetworkCredential("username", "password");
        //    smtp.EnableSsl = true;
        //    smtp.Send(mail);
        //}

        
    }
}