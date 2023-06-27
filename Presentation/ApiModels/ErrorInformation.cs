using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace API.ApiModels;

public class ErrorInformation
{
	public ErrorInformation(string type, string message, int statusCode, string? details)
	{
		Type = type;
		Message = message;
		StatusCode = statusCode;

		if(details != null)
		{
			Details = details;
		}
		else
		{
			Details = "No Details Provided";
		}
	}

	public string Type { get; set; }

	public string Message { get; set; }

	public int StatusCode { get; set; }

	public string Details { get; set; }
}
