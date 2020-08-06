Imports Microsoft.AspNet.FriendlyUrls.Resolvers

Public Class MyFriendlyURLResolver
    Inherits WebFormsFriendlyUrlResolver

    Protected Overrides Function TrySetMobileMasterPage(httpContext As HttpContextBase, page As Page, mobileSuffix As String) As Boolean

        If mobileSuffix = "Mobile" Then
            Return False
        Else
            Return MyBase.TrySetMobileMasterPage(httpContext, page, mobileSuffix)
        End If


    End Function
End Class
