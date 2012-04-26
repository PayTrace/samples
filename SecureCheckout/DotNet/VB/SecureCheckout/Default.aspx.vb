Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Net
Imports System.Text
Imports System.IO

Namespace SecureCheckout
	Partial Public Class _Default
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub btnStartOrder_OnClick(ByVal sender As Object, ByVal e As EventArgs)
			'format parameters for request 
			' to get an approval amount set: AMOUNT~1.00
			' to get a declined amount set: AMOUNT~1.12
			Dim parameters As String = "UN~demo123|PSWD~demo123|TERMS~Y|TRANXTYPE~Sale|"
			parameters &= "ORDERID~1234|AMOUNT~1.00|"

			Dim return_url As String = "http://" & Request.Url.Authority

			parameters &= "ApproveURL~" & return_url & "/Approved.aspx|"

			parameters &= "DeclineURL~" & return_url & "/Declined.aspx|"

			SendValidationRequest(parameters)
		End Sub

		Private Sub SendValidationRequest(ByVal Parameters As String)
			Dim parameter_list As String ="PARMLIST="

			parameter_list = parameter_list & Parameters
			Dim encoding As New ASCIIEncoding()
			Dim bytes() As Byte = encoding.GetBytes(parameter_list)

'INSTANT VB NOTE: The variable request was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim request_Renamed As HttpWebRequest = CType(WebRequest.Create("https://paytrace.com/api/validate.pay"), HttpWebRequest)
			request_Renamed.Method = "POST"
			request_Renamed.ContentType = "application/x-www-form-urlencoded"
			request_Renamed.ContentLength = bytes.Length

			' send validation request
			Dim str As Stream = request_Renamed.GetRequestStream()
			str.Write(bytes, 0, bytes.Length)
			str.Flush()
			str.Close()

			' get response and parse
'INSTANT VB NOTE: The variable response was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim response_Renamed As WebResponse = request_Renamed.GetResponse()
			Dim rsp_stream As Stream = response_Renamed.GetResponseStream()
			Dim reader As New StreamReader(rsp_stream)

			' read the response string
			Dim strResponse As String = reader.ReadToEnd()
			ParseResponse(strResponse)
			UpdateResponse(strResponse)
		End Sub


		Private Sub UpdateResponse(ByVal strResponse As String)
			lblResponce.Text = strResponse
			lblOrderID.Text = CStr(Session("OrderID"))
			lblAUTHKEY.Text = CStr(Session("AuthKey"))
			Dim url As String = "https://paytrace.com/api/checkout.pay?parmList=orderID~{0}|AuthKey~{1}"

			lnkSendToBilling.NavigateUrl = String.Format(url, lblOrderID.Text, lblAUTHKEY.Text)
			pnl_response.Visible = True
		End Sub

		Private Sub ParseResponse(ByVal strResponse As String)
			' if we have errors if so output to ui
			If Not strResponse.Contains("ERROR") Then
				lblResponce.Text = strResponse
				Dim parameters() As String = strResponse.Split("|"c)
				Dim OrderID As String = parameters(0).Split("~"c)(1)
				Dim AUTHKEY As String = parameters(1).Split("~"c)(1)
				Session("OrderID") = OrderID
				Session("AuthKey") = AUTHKEY
			Else
				lblResponce.Text = strResponse
			End If
		End Sub
	End Class

End Namespace
