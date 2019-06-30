using CsQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ParseHtml
{
  public partial class Form1 : Form
  {
    private string hotelName = "";
    private string checkIn = "";
    private string checkOut = "";
    private string adults = "";
    private string room = "";
    private string meal = "";
    private string address = "";
    private string reservation = "";
    private string reservationName = "";
    private string pageCount = "";
    private List<string> guests = new List<string>();
    public Form1()
    {
      InitializeComponent();
    }

    private void searchButton_Click(object sender, EventArgs e)
    {
      //linkTextBox.Text = "https://crm.ostrovok.in/orders/254599371/voucher/?lang=en";
      webBrowser1.Navigate(linkTextBox.Text);
    }

    private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
    {
      linkTextBox.Text = webBrowser1.Url.ToString();
    }

    private void parseButton_Click(object sender, EventArgs e)
    {
      Parse(0);
    }

    private string trim(string str)
    {
      var res = Regex.Replace(str, @"\t|\n|\r", "");
      RegexOptions options = RegexOptions.None;
      Regex regex = new Regex("[ ]{2,}", options);
      res = regex.Replace(res, " ").TrimEnd(' ').TrimStart(' ');
      return res;
    }

    private void Clear()
    {
      hotelName = "";
      checkIn = "";
      checkOut = "";
      adults = "";
      room = "";
      meal = "";
      address = "";
      reservation = "";
      reservationName = "";
      guests.Clear();
    }

    private void Parse(int type)
    {
      Clear();
      var test2 = CQ.Create(webBrowser1.DocumentText);
      var table = test2.Find("table").ToList().FirstOrDefault(x => x.ClassName.Contains("displaytagTable"))?.ChildNodes[1];
      if (table != null)
      {
        for (int i = 4; i < table.ChildNodes.Length; i += 4)
        {
          var name = trim(table.ChildNodes[i].ChildNodes[5].FirstChild.NodeValue);
          var code = trim(table.ChildNodes[i + 2].ChildNodes[1].FirstElementChild.FirstChild.NodeValue);
        }
      }

      foreach (IDomObject h2 in test2.Find("h2").ToList())
      {
        if (h2.ClassName != null && h2.ClassName.Equals("voucher-header-hotel-name"))
        {
          hotelName = h2.FirstChild.NodeValue;
        }
      }
      var flag = false;
      foreach (IDomObject td in test2.Find("td").ToList())
      {

        if (td.ClassName != null && td.ClassName.Equals("voucher-tax-item-title"))
        {
          if (trim(td.FirstChild.NodeValue) == "Meal:")
            flag = true;
        }

        if (td.ClassName != null && td.ClassName.Equals("voucher-tax-item-text"))
        {
          if (flag)
          {
            meal = trim(td.FirstChild.NodeValue);
            break;
          }

        }
      }

      foreach (IDomObject div in test2.Find("div").ToList())
      {
        if (div.ClassName != null && div.ClassName.Equals("voucher-header-hotel-accomd-checkin-text"))
        {
          if (div.FirstChild.NodeValue.Contains("from"))
            checkIn = trim(div.FirstChild.NodeValue).Substring(0, 8);
          if (div.FirstChild.NodeValue.Contains("until"))
            checkOut = trim(div.FirstChild.NodeValue).Substring(0, 8);
        }
        if (div.ClassName != null && div.ClassName.Equals("voucher-room-roomname"))
        {
          adults = trim(div.FirstChild.NodeValue.Substring(div.FirstChild.NodeValue.IndexOf(", for") + 5));
          room = trim(trim(div.FirstChild.NodeValue).Substring(0, trim(div.FirstChild.NodeValue).IndexOf(", for")));
        }

        if (div.ClassName != null && div.ClassName.Equals("voucher-header-info-codes"))
        {
          reservation = trim(div.FirstChild.NodeValue).Split(' ')[1];
        }

        if (div.ClassName != null && div.ClassName.Equals("voucher-header-info-partner"))
        {
          reservationName = trim(div.FirstChild.NodeValue).Substring(trim(div.FirstChild.NodeValue).IndexOf("partner") + 8);
        }


      }

      foreach (IDomObject p in test2.Find("p").ToList())
      {
        if (p.ClassName != null && p.ClassName.Equals("item-guest-and-room-text"))
        {
          guests.Add(p.FirstChild.NodeValue);
        }
      }

      foreach (IDomObject p in test2.Find("p").ToList())
      {
        if (p.ClassName != null && p.ClassName.Equals("voucher-header-hotel-meta-info-text"))
        {
          address = trim(p.FirstChild.NodeValue);
          break;
        }
      }
      var guestsSB = new StringBuilder();
      var teamTemplate = new StringBuilder();
      var vpTemplate = new StringBuilder();
      for (int i = 0; i < guests.Count; i++)
      {
        guestsSB.Append(guests[i]);
        if (i != guests.Count - 1)
          guestsSB.Append(", ");
      }

      teamTemplate.Append(
        "Dear team, \n\n" +
        "We’ve made a booking at your hotel through the supplier.Could you please check it and confirm that everything is fine with the booking:\n\n" +
        $"1.Supplier name: {reservationName} \n   Supplier's reference number: {reservation}\n\n" +
        $"2.Hotel name: {hotelName}\n\n" +
        $"3.Hotel address(please, confirm it is correct address): {address}\n\n" +
        $"4.Guest's Name: {guestsSB.ToString()}\n\n" +
        $"5.Adults: {adults}\n\n" +
        $"6.Arrival / Departure dates(if mentioned - time):  {checkIn} / {checkOut}\n\n" +
        $"7.Room type: {room}\n\n" +
        $"8.Meal type: {meal}\n\n" +
        "9.The booking has been made through our supplier, and will be paid by them. \n\n" +
        "10.Please provide hotel confirmation number if possible.Please, confirm that the room is reserved and the guest will not be asked to pay for an accommodation directly at the hotel.Only extra services are to be paid directly at the hotel.Please let us know how much is city taxes, or any additional taxes guests would need to pay.Also let us know how much is the refundable deposit and in which way it should be paid.\n\n" +
        "11.Please do not put no - show and wait till the guest check in as reservation guaranteed by the supplier and fully paid by the guest(in the case if the guest is late). \n\n" +
        "Should you have any questions or issues with this booking - please don't hesitate to contact us.\n\n" +
        "Best regards,\n" +
        "Anastasia Volkova");

      vpTemplate.Append(
        "Dear valued partner, \n\n" +
        "It seems that the hotel didn't get this booking/doesn’t see breakfasts. Could you kindly help us to reconfirm the booking with the hotel asap and check all details of reservation:\n\n" +
        $"1.Booking number from the supplier {reservation} \n\n" +
        $"2.Hotel name: {hotelName}\n\n" +
        $"3.Hotel address: (please pay attention to the hotel address to exclude mismatch situation): {address}\n\n" +
        $"4.Guest's Name: {guestsSB.ToString()}\n\n" +
        $"5.Adults: {adults}\n\n" +
        $"6.Arrival – Departure (if mentioned- time):  {checkIn} / {checkOut}\n\n" +
        $"7.Room type: {room}\n\n" +
        $"8.Meal type: {meal}\n\n" +
        "9.Please, reconfirm that room is reserved and guest will not be asked to pay for accommodation directly at the hotel. Only extra services are to be paid directly at the hotel. If any mandatory fees are not included in rate and to be paid directly by guest – we kindly ask you to inform us about the amount. \n\n" +
        "10.Could you please also provide internal hotel reservation number of this booking and/or the name of the manager you've spoken to? \n\n" +
        "11.Please inform the hotel managers not to put a no-show, as this is the guaranteed reservation. \n\n" +
        "Should you have any questions or issues with this booking - please don't hesitate to contact us."
        );

      var letter = new Letter();
      letter.titleTextBox.Text = $"Confirmation request for {guests[0]} {checkIn} \n\n";
      letter.richTextBox1.Text = type == 0 ? teamTemplate.ToString() : vpTemplate.ToString();
      letter.Show(this);
    }

    private void vpParse_Click(object sender, EventArgs e)
    {
      Parse(1);
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
      linkTextBox.Clear();
    }

    private void TextBox1_TextChanged(object sender, EventArgs e)
    {
      pageCount = tbPageCount.Text;
    }
  }
}
