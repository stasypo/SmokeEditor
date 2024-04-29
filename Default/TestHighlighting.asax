<%@ Application Inherits="Default.TestHighlighting" Codebehind="TestHighlighting.asax.cs" Language="C#" %>
<script runat="server">
	
	/// <summary>Summary.</summary>
	/// <param name="bar">A <see cref="string"/> to pass to <c>FOO</c>.</param>
	private void Foo(string bar)
	{
		string? value = null;
		var i = 0;
		var number = bar;
		
		Console.WriteLine(value);
		Console.WriteLine(value);
		Console.WriteLine(value);
	}


</script>
<%
	StringBuilder x;
%>
