using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace Control_TellStick
{
    public class LoginStep1
    {
        public string authUrl { get; set; }
        public string token { get; set; }
    }

    public class ReqToken
    {
        public string allowRenew { get; set; }
        public string expires { get; set; }
        public string token { get; set; }
    }

    public class Device
    {
        public int id { get; set; }
        public int methods { get; set; }
        public string name { get; set; }
        public int state { get; set; }
        public string statevalue { get; set; }
        public string type { get; set; }
    }

    public class DeviceRootObject
    {
        public List<Device> device { get; set; }
    }
    public class Sensor
    {
        public int id { get; set; }
        public string model { get; set; }
        public string name { get; set; }
        public bool novalues { get; set; }
        public string protocol { get; set; }
        public int sensorId { get; set; }
    }

    public class SensorRootObject
    {
        public List<Sensor> sensor { get; set; }
    }

    public class Data
    {
        public string name { get; set; }
        public int scale { get; set; }
        public double value { get; set; }
    }

    public class SensorData
    {
        public List<Data> data { get; set; }
        public int id { get; set; }
        public string model { get; set; }
        public string name { get; set; }
        public string protocol { get; set; }
        public int sensorId { get; set; }
    }

    public class DeviceData
    {
        public int id { get; set; }
        public string name { get; set; }
        public int state { get; set; }
        public string protocol { get; set; }
    }

    public static class Helper
    {
        public static string AsJsonList<T>(List<T> tt)
        {
            return new JavaScriptSerializer().Serialize(tt);
        }
        public static string AsJson<T>(T t)
        {
            return new JavaScriptSerializer().Serialize(t);
        }
        public static List<T> AsObjectList<T>(string tt)
        {
            return new JavaScriptSerializer().Deserialize<List<T>>(tt);
        }
        public static T AsObject<T>(string t)
        {
            return new JavaScriptSerializer().Deserialize<T>(t);
        }
    }

    public class TelldusFunctions
    {
        RestClient client = null;
        public string TellstickURL { get; set; }
        public string TelldusBearerToken { get; set; }
        public TelldusFunctions(string TellstickURLorName, string BearerToken)
        {
            try
            {
                TellstickURL = TellstickURLorName;
                TelldusBearerToken = BearerToken;

                client = new RestClient(TellstickURL);
                client.AddDefaultHeader("Authorization", " Bearer " + TelldusBearerToken);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public DeviceRootObject GetListOfDevices()
        {
            DeviceRootObject devRoot = null;

            try
            {
                RestRequest request = new RestRequest("/api/devices/list", Method.GET);
                request.AddParameter("supportedMethods", "3");
                var response = client.Execute(request);
                devRoot = JsonConvert.DeserializeObject<DeviceRootObject>(response.Content);
                return devRoot;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public SensorRootObject GetListOfSensors()
        {
            SensorRootObject senRoot = null;

            try
            {
                RestRequest request = new RestRequest("/api/sensors/list", Method.GET);
                var response = client.Execute(request);
                senRoot = JsonConvert.DeserializeObject<SensorRootObject>(response.Content);
                return senRoot;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public SensorData GetSensorData(int SensorID)
        {
            SensorData senData = null;

            try
            {
                RestRequest request = new RestRequest("/api/sensor/info", Method.GET);
                request.AddParameter("id", SensorID);

                var response = client.Execute(request);

                senData = JsonConvert.DeserializeObject<SensorData>(response.Content);
                return senData;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DeviceData GetDeviceData(int DeviceID)
        {
            DeviceData devData = null;

            try
            {
                RestRequest request = new RestRequest("/api/device/info", Method.GET);
                request.AddParameter("supportedMethods", "3");
                request.AddParameter("id", DeviceID);

                var response = client.Execute(request);

                devData = JsonConvert.DeserializeObject<DeviceData>(response.Content);
                return devData;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void TurnOn(int DeviceID)
        {
            try
            {
                RestRequest request = new RestRequest("/api/device/turnOn", Method.GET);
                request.AddParameter("id", DeviceID);

                var response = client.Execute(request);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public void TurnOff(int DeviceID)
        {
            try
            {
                RestRequest request = new RestRequest("/api/device/turnOff", Method.GET);
                request.AddParameter("id", DeviceID);

                var response = client.Execute(request);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

    }

}
