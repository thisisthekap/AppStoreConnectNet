using System.Threading.Tasks;
using Xunit;

namespace AppStoreConnect.Test
{
	public class Test
	{
		[Fact]
		public async Task ProfilesGetCollectionAllAsync()
		{
			var config = Util.GetConfig();

			var api = new AppStoreConnect.Net.Api.ProfilesApi(config);

			var profiles = await api.ProfilesGetCollectionAsync().ConfigureAwait(false);

			foreach (var profile in profiles.Data)
			{
				Assert.NotNull(profile.Attributes.Uuid);
			}

			Assert.NotEmpty(profiles.Data);
		}
	}
}
