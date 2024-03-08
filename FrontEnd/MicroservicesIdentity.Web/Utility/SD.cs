using System;
namespace MicroservicesIdentity.Web.Utility
{
	public class SD
	{
        public static string EventAPIBase { get; set; }
        public static string SpeakerAPIBase { get; set; }
        public static string SessionAPIBase { get; set; }
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}

