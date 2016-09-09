using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace Grammophone.Domos.Environment.Owin
{
	/// <summary>
	/// ASP.NET Identity implementation for <see cref="IUserContext"/>.
	/// </summary>
	public class OwinUserContext : IUserContext
	{
		#region Construction

		/// <summary>
		/// CReate.
		/// </summary>
		public OwinUserContext()
		{
			var currentContext = System.Web.HttpContext.Current;

			var identity = currentContext.User.Identity;

			if (identity.IsAuthenticated)
			{
				this.UserID = identity.GetUserId<long>();
			}
		}

		#endregion

		#region IUserContext Members

		/// <summary>
		/// The ID of the current user or null if anonymous.
		/// </summary>
		public long? UserID
		{
			get;
			private set;
		}

		#endregion
	}
}
