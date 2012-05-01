Imports System.Collections.Specialized
Imports System.Linq
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.IO

Namespace SilentPostResponse
	Partial Public Class SilentPostResponse
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			Try
				If Request.RequestType = "POST" Then
					Using reader As New StreamReader(Request.InputStream)
						Dim rawpost As String = reader.ReadToEnd()
						Dim paramslist As String = Server.UrlDecode(rawpost)

						ParseAndSaveParamList(paramslist.Replace("parmList=", ""))
					End Using
				End If
 ' if it blows up we want to save the exception to view
			Catch ex As Exception
				SaveException(ex)
			End Try

		End Sub

		''' <summary>
		''' Saves the exeption as a in a post object message field.
		''' </summary>
		''' <param name="e">The exception we want to save </param>
		Private Sub SaveException(ByVal e As Exception)
			Dim ex_post As New Post()
			ex_post.Message = e.Message
			ex_post.Date = Date.Now

			Dim PostModel As New PostModelEntities()
			PostModel.AddToPosts(ex_post)

			PostModel.SaveChanges()
		End Sub


		''' <summary>
		''' Parse parameter list to post object and save to database
		''' </summary>
		''' <param name="ParameterString"></param>
		Private Sub ParseAndSaveParamList(ByVal ParameterString As String)
			Dim parameters = ParameterString.Split("|"c)
			Dim ParameterList As New Dictionary(Of String, String)()

			For Each KeyValuePair In parameters
				Dim pair = KeyValuePair.Split("~"c)
				If pair IsNot Nothing AndAlso pair.Length > 1 Then
					If pair(0) IsNot Nothing AndAlso pair(1) IsNot Nothing Then
						ParameterList.Add(pair(0), pair(1))
					End If
				End If
			Next KeyValuePair

			' create a post object and save
			Dim new_post As New Post()
			new_post.OrderID = ParameterList("ORDERID")
			new_post.TransactionID = ParameterList("TRANSACTIONID")
			new_post.AppCode = ParameterList("APPCODE")
			new_post.Message = ParameterList("APPMSG")
			new_post.Date = Date.Now

			Dim PostModel As New PostModelEntities()
			PostModel.AddToPosts(new_post)

			PostModel.SaveChanges()
		End Sub


	End Class
End Namespace