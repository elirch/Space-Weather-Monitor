using System.Text;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace Space_Weather_Monitor
{
    public partial class pnlWeatherOverview : Form
    {
        // HttpClient initialization
        private static readonly HttpClient httpClient = new HttpClient();
        private int currentNotificationIndex = 0; // Keep track of which notification is currently displayed
        private NotificationResponse[] allNotifications; // Store all notifications here

        private Size smallSize = new Size(204, 194);
        private Size largeSize = new Size(500, 500);


        public pnlWeatherOverview()
        {
            InitializeComponent();
            notificationTimer = new Timer();
            notificationTimer.Interval = 5000;  // Set interval to 5 seconds
            notificationTimer.Tick += notificationTimer_Tick;  // Connect Tick event to method
            notificationTimer.Enabled = true;  // Start the timer


            // Update the base address to NASA's endpoint
            httpClient.BaseAddress = new Uri("https://api.nasa.gov/DONKI/");
            btnApod.Click += btnApod_Click;
            pictureBoxApod.Size = smallSize;


        }

        // Geomagnetic Storm Model
        public class GeomagneticStormResponse
        {
            public string gstID { get; set; }
            public string startTime { get; set; }
            public KpIndex[] allKpIndex { get; set; }
            public class KpIndex
            {
                public string observedTime { get; set; }
                public double kpIndex { get; set; }
                public string source { get; set; }
            }
            public LinkedEvent[] linkedEvents { get; set; }
            public class LinkedEvent
            {
                public string activityID { get; set; }
            }
            public string link { get; set; }
        }

        private async Task<GeomagneticStormResponse[]> FetchGeomagneticStormData()
        {
            string endpoint = $"GST?api_key=7Ph9VH1wlJD8hAhYyotBBlTayoeWjemuYptf2HXJ";

            HttpResponseMessage response = await httpClient.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<GeomagneticStormResponse[]>(responseData);
            }
            else
            {
                string errorResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error fetching data. Status Code: {response.StatusCode}. Message: {errorResponse}");
                return null;
            }
        }

        public class SolarFlareResponse
        {
            public string flrID { get; set; }
            public string beginTime { get; set; }
            public string peakTime { get; set; }
            public string endTime { get; set; }
            public string classType { get; set; }
            public string sourceLocation { get; set; }
            public int? activeRegionNum { get; set; }  // Made this a nullable integer
            public string link { get; set; }
        }

        

        private async Task<SolarFlareResponse[]> FetchSolarFlareData()
        {
            string endpoint = $"FLR?api_key=7Ph9VH1wlJD8hAhYyotBBlTayoeWjemuYptf2HXJ";

            HttpResponseMessage response = await httpClient.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<SolarFlareResponse[]>(responseData);
            }
            else
            {
                string errorResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error fetching solar flare data. Status Code: {response.StatusCode}. Message: {errorResponse}");
                return null;
            }
        }
        public class InterplanetaryShockResponse
        {
            public string catalog { get; set; }
            public string activityID { get; set; }
            public string location { get; set; }
            public string eventTime { get; set; }
            public string link { get; set; }
            public Instrument[] instruments { get; set; }

            public class Instrument
            {
                public string displayName { get; set; }
            }
        }


        private async Task<InterplanetaryShockResponse[]> FetchIPSData()
        {
            string endpoint = $"IPS?api_key=7Ph9VH1wlJD8hAhYyotBBlTayoeWjemuYptf2HXJ";
                            //$"FLR?api_key=7Ph9VH1wlJD8hAhYyotBBlTayoeWjemuYptf2HXJ"
            HttpResponseMessage response = await httpClient.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<InterplanetaryShockResponse[]>(responseData);
            }
            else
            {
                string errorResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error fetching IPS data. Status Code: {response.StatusCode}. Message: {errorResponse}");
                return null;
            }
        }


        public class MagnetopauseCrossingResponse
        {
            public string mpcID { get; set; }
            public string eventTime { get; set; }
            public Instrument[] instruments { get; set; }
            public LinkedEvent[] linkedEvents { get; set; }
            public string link { get; set; }

            public class Instrument
            {
                public string displayName { get; set; }
            }

            public class LinkedEvent
            {
                public string activityID { get; set; }
            }
        }

        private async Task<MagnetopauseCrossingResponse[]> FetchMagnetopauseCrossingData()
        {
            string endpoint = $"FLR?api_key=7Ph9VH1wlJD8hAhYyotBBlTayoeWjemuYptf2HXJ";

            HttpResponseMessage response = await httpClient.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("successsssssssssssssssss MagnetopauseCrossing");
                var responseData = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<MagnetopauseCrossingResponse[]>(responseData);
            }
            else
            {
                string errorResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error fetching MPC data. Status Code: {response.StatusCode}. Message: {errorResponse}. Response Content: {errorResponse}");
                return null;
            }
        }


        public class RadiationBeltEnhancementResponse
        {
            public string rbeID { get; set; }
            public string eventTime { get; set; }
            public Instrument[] instruments { get; set; }
            public LinkedEvent[] linkedEvents { get; set; }
            public string link { get; set; }

            public class Instrument
            {
                public string displayName { get; set; }
            }

            public class LinkedEvent
            {
                public string activityID { get; set; }
            }
        }

        private async Task<RadiationBeltEnhancementResponse[]> FetchRadiationBeltEnhancementData()
        {
            string endpoint = $"RBE?api_key=7Ph9VH1wlJD8hAhYyotBBlTayoeWjemuYptf2HXJ";

            HttpResponseMessage response = await httpClient.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<RadiationBeltEnhancementResponse[]>(responseData);
            }
            else
            {
                string errorResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error fetching RBE data. Status Code: {response.StatusCode}. Message: {errorResponse}");
                return null;
            }
        }




        public class NotificationResponse
        {
            public string messageType { get; set; }
            public string messageID { get; set; }
            public string messageURL { get; set; }
            public string messageIssueTime { get; set; }
            public string messageBody { get; set; }
        }

        private async Task<NotificationResponse[]> FetchNotifications()
        {
            string endpoint = $"notifications?api_key=7Ph9VH1wlJD8hAhYyotBBlTayoeWjemuYptf2HXJ";

            HttpResponseMessage response = await httpClient.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<NotificationResponse[]>(responseData);
            }
            else
            {
                string errorResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error fetching notifications. Status Code: {response.StatusCode}. Message: {errorResponse}");
                return null;
            }
        }

        public class ApodResponse
        {
            public string Date { get; set; }
            public string Title { get; set; }
            public string Explanation { get; set; }
            public string Url { get; set; }
            // ... other properties if needed
        }

        private async Task<ApodResponse> FetchAPODData()
        {
            string endpoint = "https://api.nasa.gov/planetary/apod?api_key=7Ph9VH1wlJD8hAhYyotBBlTayoeWjemuYptf2HXJ"; // You might want to change the API key

            HttpResponseMessage response = await httpClient.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApodResponse>(responseData);
            }
            else
            {
                string errorResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error fetching APOD data. Status Code: {response.StatusCode}. Message: {errorResponse}");
                return null;
            }
        }


        private async void pnlWeatherOverview_Load(object sender, EventArgs e)
        {
            GeomagneticStormResponse[] data = await FetchGeomagneticStormData();
            if (data != null && data.Length > 0)
            {
                label2.Text = "Latest Geomagnetic Storm\n Kp Index: " + data[0].allKpIndex[0]?.kpIndex;

                // Display the storm start time in lblStartTime
                DateTime stormStartTime = DateTime.Parse(data[0].startTime);
                lblStartTime.Text = "Storm Start Time:\n " + stormStartTime.ToString("MMMM dd, yyyy HH:mm tt");
            }
            else
            {
                label2.Text = "Failed to fetch data.";
            }


            SolarFlareResponse[] solarData = await FetchSolarFlareData();
            if (solarData != null && solarData.Length > 0)
            {
                // Displaying the latest solar flare data
                solarFlareActivity.Text = $"Latest Solar Flare:\nClass: {solarData[0].classType}\n" +
                                          $"Begin: {solarData[0].beginTime}\n" +
                                          $"Peak: {solarData[0].peakTime}\n" +
                                          $"End: {solarData[0].endTime ?? "Ongoing"}\n" +
                                          $"Source Location: {solarData[0].sourceLocation}\n" +
                                          $"Active Region Number: {solarData[0].activeRegionNum}";
            }
            else
            {
                solarFlareActivity.Text = "Failed to fetch solar flare data.";
            }

            InterplanetaryShockResponse[] ipsData = await FetchIPSData();
            if (ipsData != null && ipsData.Length > 0)
            {
                // Let's say the label you added inside groupBox3 is named labelIPSInfo
                labelIPSInfo.Text = $"Latest Interplanetary Shock:\nCatalog: {ipsData[0].catalog}\n" +
                                    $"Location: {ipsData[0].location}\n" +
                                    $"Event Time: {ipsData[0].eventTime}\n" +
                                    $"Instruments: \n{string.Join(", ", ipsData[0].instruments.Select(i => i.displayName))}\n";
                                    //$"Link: {ipsData[0].link}";
            }
            else
            {
                labelIPSInfo.Text = "Failed to fetch IPS data.";
            }


            // Fetch and update Magnetopause Crossing data
            MagnetopauseCrossingResponse[] mpcData = await FetchMagnetopauseCrossingData();
            if (mpcData != null && mpcData.Length > 0)
            {
                string instruments = (mpcData[0].instruments != null)
                                      ? string.Join(", ", mpcData[0].instruments.Select(i => i.displayName))
                                      : "N/A";

                int linkedEventsCount = (mpcData[0].linkedEvents != null)
                                         ? mpcData[0].linkedEvents.Length
                                         : 0;

                labelMPCInfo.Text = $"Latest Magnetopause Crossing:\n\nEvent Time: {mpcData[0].eventTime}\n" +
                                    $"Instruments: {instruments}\n" +
                                    $"Linked Events Count: {linkedEventsCount}\n";
                                    //$"Link: {mpcData[0].link}";
            }
            else
            {
                labelMPCInfo.Text = "Failed to fetch MPC data.";
            }

            // Fetch and update Radiation Belt data
            RadiationBeltEnhancementResponse[] rbeData = await FetchRadiationBeltEnhancementData();
            if (rbeData != null && rbeData.Length > 0)
            {
                labelRBEInfo.Text = $"Latest Radiation Belt Enhancement:\nEvent Time: {rbeData[0].eventTime}\n" +
                                    $"Instruments: {string.Join(", ", rbeData[0].instruments.Select(i => i.displayName))}\n" +
                                    $"Linked Events Count: {rbeData[0].linkedEvents.Length}\n";
                                    //$"Link: {rbeData[0].link}";
            }
            else
            {
                labelRBEInfo.Text = "Failed to fetch RBE data.";
            }


            // Fetch notifications
            NotificationResponse[] notifications = await FetchNotifications();
            if (notifications != null && notifications.Length > 0)
            {
                allNotifications = notifications;

                notificationsTextBox.Text = allNotifications[currentNotificationIndex].messageBody;

                notificationTimer.Start();
            }
        }

        private void notificationTimer_Tick(object sender, EventArgs e)
        {
            // Null check for allNotifications.
            if (allNotifications == null || allNotifications.Length == 0)
            {
                Console.WriteLine("No notifications available.");
                return; // exit the method early
            }

            Console.WriteLine("Timer Tick!");

            currentNotificationIndex++;
            if (currentNotificationIndex >= allNotifications.Length)
            {
                currentNotificationIndex = 0; // Loop back to the beginning
            }

            // Additional null check to avoid potential NullReferenceException.
            if (allNotifications[currentNotificationIndex] == null)
            {
                Console.WriteLine($"Notification at index {currentNotificationIndex} is null.");
                return;
            }

            Console.WriteLine("Notification Message Body: " + allNotifications[currentNotificationIndex].messageBody);

            // Extracting the relevant message content
            string fullMessage = allNotifications[currentNotificationIndex].messageBody;

            // Log the full messageBody to the console for reference
            Console.WriteLine("Full Notification Message Body: " + fullMessage);

            if (fullMessage.Contains("Summary:"))
            {
                string[] parts = fullMessage.Split(new string[] { "Summary:" }, StringSplitOptions.None);
                if (parts.Length > 1)
                {
                    string relevantPart = parts[1].Trim();
                    notificationsTextBox.Text = relevantPart + "\n\n--- end of message ----";
                }
                else
                {
                    notificationsTextBox.Text = fullMessage + "\n\n--- end of message ----";
                }
            }
            else
            {
                notificationsTextBox.Text = fullMessage;
            }
        }


        private async void btnApod_Click(object sender, EventArgs e)
        {
            ApodResponse apodData = await FetchAPODData();
            if (apodData != null)
            {
                pictureBoxApod.Load(apodData.Url);
                // You can also show the Title, Explanation, and Date somewhere on your form, if desired.
            }
        }

        private void pictureBoxApod_Click(object sender, EventArgs e)
        {
            if (pictureBoxApod.Size == smallSize)
            {
                pictureBoxApod.Size = largeSize;
                pictureBoxApod.BringToFront(); // So that it comes on top of other controls
            }
            else
            {
                pictureBoxApod.Size = smallSize;
            }
        }
    }
}
