using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialText.Utilities
{
    public class Response
    {
        public bool Success { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public override string ToString()
        {
            return string.Format("CODE={0}, {1}", Code, Message);
        }
    }

    public static class Responses
    {
        public static Response Success = new Response()
        {
            Success = true,
            Code = 0,
            Message = "Success"
        };

        public static Response OpenSuccess(string portName)
        {
            Response res = new Response()
            {
                Success = true,
                Code = 0,                
            };
            res.Message = string.Format("Open {0} success.",portName);
            return res;
        }

        public static Response UnknownError = new Response()
        {
            Success = false,
            Code = 1,
            Message = "Unknown error!"
        };

        public static Response InvalidInput = new Response()
        {
            Success = false,
            Code = 2,
            Message = "Invalid input!"
        };

        public static Response PortNotFound(string portName)
        {
            Response res = new Response()
            {
                Success = false,
                Code = 3,
            };
            res.Message = string.Format("{0} not found!", portName);
            return res;
        }

        public static Response PortTimeout = new Response()
        {
            Success = false,
            Code = 4,
            Message = "Port time-out!"
        };

        public static Response OpenFailed = new Response()
        {
            Success = false,
            Code = 5,
            Message = "Open port failed!"
        };

        public static Response NoBytesToRead = new Response()
        {
            Success = false,
            Code = 6,
            Message = "No bytes to read!"
        };

        public static Response LrcFailed = new Response()
        {
            Success = false,
            Code = 7,
            Message = "LRC failed!"
        };
    }
}
