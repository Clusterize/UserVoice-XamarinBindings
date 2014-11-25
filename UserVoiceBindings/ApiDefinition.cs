using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace UserVoiceBindingsClassic
{
	[BaseType (typeof (NSObject))]
	interface UserVoice
	{
		[Static, Export ("initialize:")]
		void Initialize (UVConfig config);

		[Static, Export ("presentUserVoiceInterfaceForParentViewController:")]
		void PresentUserVoiceInterface (UIViewController parentViewController);

		[Static, Export ("presentUserVoiceContactUsFormForParentViewController:")]
		void PresentUserVoiceContactUsForm (UIViewController parentViewController);

		[Static, Export ("presentUserVoiceNewIdeaFormForParentViewController:")]
		void PresentUserVoiceNewIdeaForm (UIViewController parentViewController);

		[Static, Export ("presentUserVoiceForumForParentViewController:")]
		void PresentUserVoiceForum (UIViewController parentViewController);

		[Static, Export ("getUserVoiceContactUsFormForModalDisplay")]
		UIViewController UserVoiceContactUsFormForModalDisplay { get; }

		[Static, Export ("delegate:")]
		UVDelegate Delegate { get; set; }

		[Static, Export ("presentUserVoiceContactUsFormForParentViewController:andConfig:")]
		void PresentUserVoiceContactUsForm (UIViewController parentViewController, UVConfig config);

		[Static, Export ("presentUserVoiceNewIdeaFormForParentViewController:andConfig:")]
		void PresentUserVoiceNewIdeaForm (UIViewController parentViewController, UVConfig config);

		[Static, Export ("presentUserVoiceForumForParentViewController:andConfig:")]
		void PresentUserVoiceForum (UIViewController parentViewController, UVConfig config);

		[Static, Export ("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:")]
		void PresentUserVoiceModalViewController (UIViewController viewController, string site, string key, string secret);

		[Static, Export ("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:andSsoToken:")]
		void PresentUserVoiceModalViewController (UIViewController viewController, string site, string key, string secret, string token);

		[Static, Export ("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:andEmail:andDisplayName:andGUID:")]
		void PresentUserVoiceModalViewController (UIViewController viewController, string site, string key, string secret, string email, string displayName, string guid);
	}

	[BaseType (typeof (NSObject))]
	interface UVConfig
	{
		[Static, Export ("configWithSite:")]
		UVConfig ConfigWithSite (string site);

		[Export ("site")]
		string Site { get; set; }

		[Export ("key")]
		string Key { get; set; }

		[Export ("secret")]
		string Secret { get; set; }

		[Export ("ssoToken")]
		string SsoToken { get; set; }

		[Export ("displayName")]
		string DisplayName { get; set; }

		[Export ("email")]
		string Email { get; set; }

		[Export ("guid")]
		string Guid { get; set; }

		[Export ("customFields")]
		NSDictionary CustomFields { get; set; }

		[Export ("topicId")]
		int TopicId { get; set; }

		[Export ("forumId")]
		int ForumId { get; set; }

		[Export ("showForum")]
		bool ShowForum { get; set; }

		[Export ("showPostIdea")]
		bool ShowPostIdea { get; set; }

		[Export ("showContactUs")]
		bool ShowContactUs { get; set; }

		[Export ("showKnowledgeBase")]
		bool ShowKnowledgeBase { get; set; }

		[Export ("extraTicketInfo")]
		string ExtraTicketInfo { get; set; }

		[Export ("userTraits")]
		NSDictionary UserTraits { get; set; }

		[Export ("identifyUserWithEmail:name:guid:")]
		void IdentifyUser (string email, string name, string guid);

		[Export ("traits")]
		NSDictionary Traits { get; }
	}

	[BaseType (typeof (NSObject))]
	[Model]
	interface UVDelegate
	{
		[Export ("userVoiceWasDismissed")]
		void UserVoiceWasDismissed ();

		[Export ("userVoiceRequestsDismissal")]
		void UserVoiceRequestsDismissal ();
	}

	[BaseType (typeof (NSObject))]
	interface UVStyleSheet
	{
		[Static, Export ("instance")]
		UVStyleSheet Instance { get; }

		[Export ("tintColor")]
		UIColor TintColor { get; set; }

		[Export ("tableViewBackgroundColor")]
		UIColor TableViewBackgroundColor { get; set; }

		[Export ("navigationBarBackgroundColor")]
		UIColor NavigationBarBackgroundColor { get; set; }

		[Export ("navigationBarTextColor")]
		UIColor NavigationBarTextColor { get; set; }

		[Export ("navigationBarTextShadowColor")]
		UIColor NavigationBarTextShadowColor { get; set; }

		[Export ("navigationBarBackgroundImage")]
		UIImage NavigationBarBackgroundImage { get; set; }

		[Export ("navigationBarFont")]
		UIFont  NavigationBarFont { get; set; }

		[Export ("navigationBarTintColor")]
		UIColor NavigationBarTintColor { get; set; }

		[Export ("navigationBarActivityIndicatorColor")]
		UIColor NavigationBarActivityIndicatorColor { get; set; }

		[Export ("loadingViewBackgroundColor")]
		UIColor LoadingViewBackgroundColor { get; set; }

		[Export ("preferredStatusBarStyle")]
		UIStatusBarStyle PreferredStatusBarStyle { get; set; }
	}
}