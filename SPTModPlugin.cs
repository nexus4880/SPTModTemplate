using BepInEx;

namespace {AuthorName}.SPTMod {
	[BepInPlugin("{AuthorDomain}.sptmod", "SPTMod", "1.0.0")]
	public class SPTModPlugin : BaseUnityPlugin {
		private void Awake() {
			this.Logger.LogInfo("Initialized");
		}

		private void OnDestroy() {
			this.Logger.LogInfo("Uninitialized");
		}
	}
}