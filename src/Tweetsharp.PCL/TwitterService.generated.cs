﻿/// <summary>
/// This code is generated. Any changes to it will be destroyed on subsequent generations. Use the DSL instead.
/// </summary>

using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TweetSharp
{
#region Options 
    		
	public class ListTweetsMentioningMeOptions
	{ 
		public int? Count { get; set; }  
		public long? SinceId { get; set; }  
		public long? MaxId { get; set; }  
		public bool? TrimUser { get; set; }  
		public bool? ContributorDetails { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class ListTweetsOnUserTimelineOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public long? SinceId { get; set; }  
		public int? Count { get; set; }  
		public long? MaxId { get; set; }  
		public bool? TrimUser { get; set; }  
		public bool? ExcludeReplies { get; set; }  
		public bool? ContributorDetails { get; set; }  
		public bool? IncludeRts { get; set; } 			
	}			
 
    		
	public class ListTweetsOnHomeTimelineOptions
	{ 
		public int? Count { get; set; }  
		public long? SinceId { get; set; }  
		public long? MaxId { get; set; }  
		public bool? TrimUser { get; set; }  
		public bool? ExcludeReplies { get; set; }  
		public bool? ContributorDetails { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class ListRetweetsOfMyTweetsOptions
	{ 
		public int? Count { get; set; }  
		public long? SinceId { get; set; }  
		public long? MaxId { get; set; }  
		public bool? TrimUser { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? IncludeUserEntities { get; set; } 			
	}			
 
    		
	public class RetweetsOptions
	{ 
		public long Id { get; set; }  
		public int? Count { get; set; }  
		public bool? TrimUser { get; set; } 			
	}			
 
    		
	public class GetTweetOptions
	{ 
		public long Id { get; set; }  
		public bool? TrimUser { get; set; }  
		public bool? IncludeMyRetweet { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class DeleteTweetOptions
	{ 
		public long Id { get; set; }  
		public bool TrimUser { get; set; } 			
	}			
 
    		
	public class SendTweetOptions
	{ 
		public string Status { get; set; }  
		public long? InReplyToStatusId { get; set; }  
		public double? Lat { get; set; }  
		public double? @Long { get; set; }  
		public long? PlaceId { get; set; }  
		public bool? DisplayCoordinates { get; set; }  
		public bool? TrimUser { get; set; } 			
	}			
 
    		
	public class RetweetOptions
	{ 
		public long Id { get; set; }  
		public bool? TrimUser { get; set; } 			
	}			
 
    		
	public class SendTweetWithMediaOptions
	{ 
		public string Status { get; set; }  
		public bool? PossiblySensitive { get; set; }  
		public long? InReplyToStatusId { get; set; }  
		public double? Lat { get; set; }  
		public double? @Long { get; set; }  
		public bool? PlaceId { get; set; }  
		public bool? DisplayCoordinates { get; set; }  
		public IDictionary<string,Stream> Images { get; set; } 			
	}			
 
    		
	public class SearchOptions
	{ 
		public string Q { get; set; }  
		public TwitterGeoLocationSearch Geocode { get; set; }  
		public string Lang { get; set; }  
		public string Locale { get; set; }  
		public TwitterSearchResultType? Resulttype { get; set; }  
		public int? Count { get; set; }  
		public long? SinceId { get; set; }  
		public long? MaxId { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public string Callback { get; set; } 			
	}			
 
    		
	public class ListDirectMessagesReceivedOptions
	{ 
		public long? SinceId { get; set; }  
		public long? MaxId { get; set; }  
		public int? Count { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class ListDirectMessagesSentOptions
	{ 
		public long? SinceId { get; set; }  
		public long? MaxId { get; set; }  
		public int? Count { get; set; }  
		public int? Page { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class GetDirectMessageOptions
	{ 
		public long Id { get; set; } 			
	}			
 
    		
	public class DeleteDirectMessageOptions
	{ 
		public long Id { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class SendDirectMessageOptions
	{ 
		public string Text { get; set; }  
		public long UserId { get; set; }  
		public string ScreenName { get; set; } 			
	}			
 
    		
	public class ListFriendIdsOfOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public long? Cursor { get; set; }  
		public int? Count { get; set; } 			
	}			
 
    		
	public class ListFollowerIdsOfOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public long? Cursor { get; set; }  
		public int? Count { get; set; } 			
	}			
 
    		
	public class ListFriendshipsForOptions
	{ 
		public IEnumerable<string> ScreenName { get; set; }  
		public IEnumerable<long> UserId { get; set; } 			
	}			
 
    		
	public class GetIncomingFriendRequestsOptions
	{ 
		public long? Cursor { get; set; } 			
	}			
 
    		
	public class GetOutgoingFriendRequestsOptions
	{ 
		public long? Cursor { get; set; } 			
	}			
 
    		
	public class FollowUserOptions
	{ 
		public string ScreenName { get; set; }  
		public long? UserId { get; set; }  
		public bool? Follow { get; set; } 			
	}			
 
    		
	public class UnfollowUserOptions
	{ 
		public string ScreenName { get; set; }  
		public long? UserId { get; set; } 			
	}			
 
    		
	public class UpdateFriendshipOptions
	{ 
		public string ScreenName { get; set; }  
		public long? UserId { get; set; }  
		public bool? Device { get; set; }  
		public bool? Retweets { get; set; } 			
	}			
 
    		
	public class GetFriendshipInfoOptions
	{ 
		public string SourceId { get; set; }  
		public string SourceScreenName { get; set; }  
		public string TargetId { get; set; }  
		public string TargetScreenName { get; set; } 			
	}			
 
    		
	public class ListFriendsOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public long? Cursor { get; set; }  
		public bool? SkipStatus { get; set; }  
		public bool? IncludeUserEntities { get; set; } 			
	}			
 
    		
	public class ListFollowersOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public long? Cursor { get; set; }  
		public bool? SkipStatus { get; set; }  
		public bool? IncludeUserEntities { get; set; } 			
	}			
 
    		
	public class GetUserProfileOptions
	{ 
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class VerifyCredentialsOptions
	{ 
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class UpdateAccountSettingsOptions
	{ 
		public int? TrendLocationWoeid { get; set; }  
		public bool? SleepTimeEnabled { get; set; }  
		public int? StartSleepTime { get; set; }  
		public int? EndSleepTime { get; set; }  
		public string TimeZone { get; set; }  
		public string Lang { get; set; } 			
	}			
 
    		
	public class UpdateDeliveryDeviceOptions
	{ 
		public TwitterDeliveryDevice Device { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class UpdateProfileOptions
	{ 
		public string Name { get; set; }  
		public string Url { get; set; }  
		public string Location { get; set; }  
		public string Description { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class UpdateProfileBackgroundImageOptions
	{ 
		public string Imagepath { get; set; }  
		public bool? Tile { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; }  
		public bool? Use { get; set; } 			
	}			
 
    		
	public class UpdateProfileColorsOptions
	{ 
		public string ProfileBackgroundColor { get; set; }  
		public string ProfileLinkColor { get; set; }  
		public string ProfileSidebarBorderColor { get; set; }  
		public string ProfileSidebarFillColor { get; set; }  
		public string ProfileTextColor { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class UpdateProfileImageOptions
	{ 
		public string ImagePath { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class ListBlockedUsersOptions
	{ 
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; }  
		public long? Cursor { get; set; } 			
	}			
 
    		
	public class ListBlockedUserIdsOptions
	{ 
		public long? Cursor { get; set; } 			
	}			
 
    		
	public class BlockUserOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class UnblockUserOptions
	{ 
		public string ScreenName { get; set; }  
		public long? UserId { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class ListUserProfilesForOptions
	{ 
		public IEnumerable<string> ScreenName { get; set; }  
		public IEnumerable<long> UserId { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class GetUserProfileForOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class SearchForUserOptions
	{ 
		public string Q { get; set; }  
		public int? Page { get; set; }  
		public int? Count { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class ListSuggestedUsersOptions
	{ 
		public string Slug { get; set; }  
		public string Lang { get; set; } 			
	}			
 
    		
	public class ListSuggestedUserCategoriesOptions
	{ 
		public string Lang { get; set; } 			
	}			
 
    		
	public class GetSuggestedUserMembersOptions
	{ 
		public string Slug { get; set; } 			
	}			
 
    		
	public class ListFavoriteTweetsOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public int? Count { get; set; }  
		public long? SinceId { get; set; }  
		public long? MaxId { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class UnfavoriteTweetOptions
	{ 
		public long Id { get; set; } 			
	}			
 
    		
	public class FavoriteTweetOptions
	{ 
		public long Id { get; set; }  
		public bool? IncludeEntities { get; set; } 			
	}			
 
    		
	public class ListListsForOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; } 			
	}			
 
    		
	public class ListTweetsOnListOptions
	{ 
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; }  
		public long? SinceId { get; set; }  
		public long? MaxId { get; set; }  
		public int? Count { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? IncludeRts { get; set; } 			
	}			
 
    		
	public class RemoveListMemberOptions
	{ 
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; } 			
	}			
 
    		
	public class ListListMembershipsForOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public long? Cursor { get; set; }  
		public bool? FilterToOwnedLists { get; set; } 			
	}			
 
    		
	public class ListListSubscribersOptions
	{ 
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; }  
		public long? Cursor { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class FollowListOptions
	{ 
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; }  
		public long? ListId { get; set; }  
		public string Slug { get; set; } 			
	}			
 
    		
	public class VerifyListSubscriptionOptions
	{ 
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; }  
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class UnfollowListOptions
	{ 
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; } 			
	}			
 
    		
	public class VerifyListMembershipOptions
	{ 
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class ListListMembersOptions
	{ 
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; }  
		public long? Cursor { get; set; }  
		public bool? IncludeEntities { get; set; }  
		public bool? SkipStatus { get; set; } 			
	}			
 
    		
	public class AddListMemberOptions
	{ 
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; } 			
	}			
 
    		
	public class DeleteListOptions
	{ 
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; }  
		public long? ListId { get; set; }  
		public string Slug { get; set; } 			
	}			
 
    		
	public class CreateListOptions
	{ 
		public string ListOwner { get; set; }  
		public string Name { get; set; }  
		public TwitterListMode Mode { get; set; }  
		public string Description { get; set; } 			
	}			
 
    		
	public class GetListOptions
	{ 
		public long? ListId { get; set; }  
		public string Slug { get; set; }  
		public string OwnerScreenName { get; set; }  
		public long? OwnerId { get; set; } 			
	}			
 
    		
	public class ListSubscriptionsOptions
	{ 
		public long? UserId { get; set; }  
		public string ScreenName { get; set; }  
		public int? Count { get; set; }  
		public long? Cursor { get; set; } 			
	}			
 
    		
	public class GetSavedSearchOptions
	{ 
		public long Id { get; set; } 			
	}			
 
    		
	public class CreateSavedSearchOptions
	{ 
		public string Query { get; set; } 			
	}			
 
    		
	public class DeleteSavedSearchOptions
	{ 
		public long Id { get; set; } 			
	}			
 
    		
	public class GetPlaceOptions
	{ 
		public string PlaceId { get; set; } 			
	}			
 
    		
	public class ReverseGeocodeOptions
	{ 
		public double Lat { get; set; }  
		public double @Long { get; set; }  
		public string Accuracy { get; set; }  
		public string Granularity { get; set; }  
		public int? MaxResults { get; set; }  
		public string Callback { get; set; } 			
	}			
 
    		
	public class GeoSearchOptions
	{ 
		public double? Lat { get; set; }  
		public double? @Long { get; set; }  
		public string Query { get; set; }  
		public string Ip { get; set; }  
		public string Granularity { get; set; }  
		public string Accuracy { get; set; }  
		public int? MaxResults { get; set; }  
		public string ContainedWithin { get; set; }  
		public string Callback { get; set; } 			
	}			
 
    		
	public class ListLocalTrendsForOptions
	{ 
		public int Id { get; set; }  
		public string Exclude { get; set; } 			
	}			
 
    		
	public class ListClosestTrendsLocationsOptions
	{ 
		public double Lat { get; set; }  
		public double @Long { get; set; } 			
	}			
 
    		
	public class GetRateLimitStatusOptions
	{ 
		public IEnumerable<string> Resources { get; set; } 			
	}			
 
    		
	public class ReportSpamOptions
	{ 
		public string ScreenName { get; set; }  
		public long? UserId { get; set; } 			
	}			
#endregion

#region Interface
	public partial interface ITwitterService
	{
		#region Asynchronous Methods (with TAP pattern)
        
		Task<HttpResponse<IEnumerable<TwitterStatus>>> ListTweetsMentioningMeAsync(ListTweetsMentioningMeOptions options);


        
		Task<HttpResponse<IEnumerable<TwitterStatus>>> ListTweetsOnUserTimelineAsync(ListTweetsOnUserTimelineOptions options);


        
		Task<HttpResponse<IEnumerable<TwitterStatus>>> ListTweetsOnHomeTimelineAsync(ListTweetsOnHomeTimelineOptions options);


        
		Task<HttpResponse<IEnumerable<TwitterStatus>>> ListRetweetsOfMyTweetsAsync(ListRetweetsOfMyTweetsOptions options);


        
		Task<HttpResponse<IEnumerable<TwitterStatus>>> RetweetsAsync(RetweetsOptions options);


        
		Task<HttpResponse<TwitterStatus>> GetTweetAsync(GetTweetOptions options);


        
		Task<HttpResponse<TwitterStatus>> DeleteTweetAsync(DeleteTweetOptions options);


        
		Task<HttpResponse<TwitterStatus>> SendTweetAsync(SendTweetOptions options);


        
		Task<HttpResponse<TwitterStatus>> RetweetAsync(RetweetOptions options);


        
		Task<HttpResponse<TwitterStatus>> SendTweetWithMediaAsync(SendTweetWithMediaOptions options);


        
		Task<HttpResponse<TwitterSearchResult>> SearchAsync(SearchOptions options);


        
		Task<HttpResponse<IEnumerable<TwitterDirectMessage>>> ListDirectMessagesReceivedAsync(ListDirectMessagesReceivedOptions options);


        
		Task<HttpResponse<IEnumerable<TwitterDirectMessage>>> ListDirectMessagesSentAsync(ListDirectMessagesSentOptions options);


        
		Task<HttpResponse<TwitterDirectMessage>> GetDirectMessageAsync(GetDirectMessageOptions options);


        
		Task<HttpResponse<TwitterDirectMessage>> DeleteDirectMessageAsync(DeleteDirectMessageOptions options);


        
		Task<HttpResponse<TwitterDirectMessage>> SendDirectMessageAsync(SendDirectMessageOptions options);


        
		Task<HttpResponse<TwitterCursorList<long>>> ListFriendIdsOfAsync(ListFriendIdsOfOptions options);


        
		Task<HttpResponse<TwitterCursorList<long>>> ListFollowerIdsOfAsync(ListFollowerIdsOfOptions options);


        
		Task<HttpResponse<IEnumerable<TwitterFriendshipLookup>>> ListFriendshipsForAsync(ListFriendshipsForOptions options);


        
		Task<HttpResponse<TwitterCursorList<long>>> GetIncomingFriendRequestsAsync(GetIncomingFriendRequestsOptions options);


        
		Task<HttpResponse<TwitterCursorList<long>>> GetOutgoingFriendRequestsAsync(GetOutgoingFriendRequestsOptions options);


        
		Task<HttpResponse<TwitterUser>> FollowUserAsync(FollowUserOptions options);


        
		Task<HttpResponse<TwitterUser>> UnfollowUserAsync(UnfollowUserOptions options);


        
		Task<HttpResponse<TwitterFriendship>> UpdateFriendshipAsync(UpdateFriendshipOptions options);


        
		Task<HttpResponse<TwitterFriendship>> GetFriendshipInfoAsync(GetFriendshipInfoOptions options);


        
		Task<HttpResponse<TwitterCursorList<TwitterUser>>> ListFriendsAsync(ListFriendsOptions options);


        
		Task<HttpResponse<TwitterCursorList<TwitterUser>>> ListFollowersAsync(ListFollowersOptions options);


        
		Task<HttpResponse<TwitterAccount>> GetAccountSettingsAsync();


        
		Task<HttpResponse<TwitterUser>> GetUserProfileAsync(GetUserProfileOptions options);


        
		Task<HttpResponse<TwitterUser>> VerifyCredentialsAsync(VerifyCredentialsOptions options);


        
		Task<HttpResponse<TwitterAccount>> UpdateAccountSettingsAsync(UpdateAccountSettingsOptions options);


        
		Task<HttpResponse<TwitterUser>> UpdateDeliveryDeviceAsync(UpdateDeliveryDeviceOptions options);


        
		Task<HttpResponse<TwitterUser>> UpdateProfileAsync(UpdateProfileOptions options);


        
		Task<HttpResponse<TwitterUser>> UpdateProfileBackgroundImageAsync(UpdateProfileBackgroundImageOptions options);


        
		Task<HttpResponse<TwitterUser>> UpdateProfileColorsAsync(UpdateProfileColorsOptions options);


        
		Task<HttpResponse<TwitterUser>> UpdateProfileImageAsync(UpdateProfileImageOptions options);


        
		Task<HttpResponse<TwitterCursorList<TwitterUser>>> ListBlockedUsersAsync(ListBlockedUsersOptions options);


        
		Task<HttpResponse<TwitterCursorList<long>>> ListBlockedUserIdsAsync(ListBlockedUserIdsOptions options);


        
		Task<HttpResponse<TwitterUser>> BlockUserAsync(BlockUserOptions options);


        
		Task<HttpResponse<TwitterUser>> UnblockUserAsync(UnblockUserOptions options);


        
		Task<HttpResponse<IEnumerable<TwitterUser>>> ListUserProfilesForAsync(ListUserProfilesForOptions options);


        
		Task<HttpResponse<TwitterUser>> GetUserProfileForAsync(GetUserProfileForOptions options);


        
		Task<HttpResponse<IEnumerable<TwitterUser>>> SearchForUserAsync(SearchForUserOptions options);


        
		Task<HttpResponse<TwitterUserSuggestions>> ListSuggestedUsersAsync(ListSuggestedUsersOptions options);


        
		Task<HttpResponse<IEnumerable<TwitterUserSuggestions>>> ListSuggestedUserCategoriesAsync(ListSuggestedUserCategoriesOptions options);


        
		Task<HttpResponse<IEnumerable<TwitterUser>>> GetSuggestedUserMembersAsync(GetSuggestedUserMembersOptions options);


        
		Task<HttpResponse<IEnumerable<TwitterStatus>>> ListFavoriteTweetsAsync(ListFavoriteTweetsOptions options);


        
		Task<HttpResponse<TwitterStatus>> UnfavoriteTweetAsync(UnfavoriteTweetOptions options);


        
		Task<HttpResponse<TwitterStatus>> FavoriteTweetAsync(FavoriteTweetOptions options);


        
		Task<HttpResponse<IEnumerable<TwitterList>>> ListListsForAsync(ListListsForOptions options);


        
		Task<HttpResponse<IEnumerable<TwitterStatus>>> ListTweetsOnListAsync(ListTweetsOnListOptions options);


        
		Task<HttpResponse<TwitterUser>> RemoveListMemberAsync(RemoveListMemberOptions options);


        
		Task<HttpResponse<TwitterCursorList<TwitterList>>> ListListMembershipsForAsync(ListListMembershipsForOptions options);


        
		Task<HttpResponse<TwitterCursorList<TwitterUser>>> ListListSubscribersAsync(ListListSubscribersOptions options);


        
		Task<HttpResponse<TwitterUser>> FollowListAsync(FollowListOptions options);


        
		Task<HttpResponse<TwitterUser>> VerifyListSubscriptionAsync(VerifyListSubscriptionOptions options);


        
		Task<HttpResponse<TwitterUser>> UnfollowListAsync(UnfollowListOptions options);


        
		Task<HttpResponse<TwitterUser>> VerifyListMembershipAsync(VerifyListMembershipOptions options);


        
		Task<HttpResponse<TwitterCursorList<TwitterUser>>> ListListMembersAsync(ListListMembersOptions options);


        
		Task<HttpResponse<TwitterUser>> AddListMemberAsync(AddListMemberOptions options);


        
		Task<HttpResponse<TwitterList>> DeleteListAsync(DeleteListOptions options);


        
		Task<HttpResponse<TwitterList>> CreateListAsync(CreateListOptions options);


        
		Task<HttpResponse<TwitterList>> GetListAsync(GetListOptions options);


        
		Task<HttpResponse<TwitterCursorList<TwitterList>>> ListSubscriptionsAsync(ListSubscriptionsOptions options);


        
		Task<HttpResponse<IEnumerable<TwitterSavedSearch>>> ListSavedSearchesAsync();


        
		Task<HttpResponse<TwitterSavedSearch>> GetSavedSearchAsync(GetSavedSearchOptions options);


        
		Task<HttpResponse<TwitterSavedSearch>> CreateSavedSearchAsync(CreateSavedSearchOptions options);


        
		Task<HttpResponse<TwitterSavedSearch>> DeleteSavedSearchAsync(DeleteSavedSearchOptions options);


        
		Task<HttpResponse<TwitterPlace>> GetPlaceAsync(GetPlaceOptions options);


        
		Task<HttpResponse<IEnumerable<TwitterPlace>>> ReverseGeocodeAsync(ReverseGeocodeOptions options);


        
		Task<HttpResponse<IEnumerable<TwitterPlace>>> GeoSearchAsync(GeoSearchOptions options);


        
		Task<HttpResponse<TwitterTrends>> ListLocalTrendsForAsync(ListLocalTrendsForOptions options);


        
		Task<HttpResponse<IEnumerable<WhereOnEarthLocation>>> ListAvailableTrendsLocationsAsync();


        
		Task<HttpResponse<IEnumerable<WhereOnEarthLocation>>> ListClosestTrendsLocationsAsync(ListClosestTrendsLocationsOptions options);


        
		Task<HttpResponse<TwitterRateLimitStatusSummary>> GetRateLimitStatusAsync(GetRateLimitStatusOptions options);


        
		Task<HttpResponse<TwitterUser>> ReportSpamAsync(ReportSpamOptions options);


		#endregion
	}
#endregion
}

namespace TweetSharp
{
#region Implementation
	public partial class TwitterService : ITwitterService
	{	
		#region Sequential Methods
        
		public virtual Task<HttpResponse<IEnumerable<TwitterStatus>>> ListTweetsMentioningMe(ListTweetsMentioningMeOptions options)
		{
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var contributor_details = options.ContributorDetails;
			var include_entities = options.IncludeEntities;
				
			
			return ExecuteRequest<IEnumerable<TwitterStatus>>("statuses/mentions_timeline", FormatAsString, "?count=", count, "&since_id=", since_id, "&max_id=", max_id, "&trim_user=", trim_user, "&contributor_details=", contributor_details, "&include_entities=", include_entities);
		}

        
		public virtual Task<HttpResponse<IEnumerable<TwitterStatus>>> ListTweetsOnUserTimeline(ListTweetsOnUserTimelineOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var since_id = options.SinceId;
			var count = options.Count;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var exclude_replies = options.ExcludeReplies;
			var contributor_details = options.ContributorDetails;
			var include_rts = options.IncludeRts;
				
			
			return ExecuteRequest<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&since_id=", since_id, "&count=", count, "&max_id=", max_id, "&trim_user=", trim_user, "&exclude_replies=", exclude_replies, "&contributor_details=", contributor_details, "&include_rts=", include_rts);
		}

        
		public virtual Task<HttpResponse<IEnumerable<TwitterStatus>>> ListTweetsOnHomeTimeline(ListTweetsOnHomeTimelineOptions options)
		{
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var exclude_replies = options.ExcludeReplies;
			var contributor_details = options.ContributorDetails;
			var include_entities = options.IncludeEntities;
				
			
			return ExecuteRequest<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?count=", count, "&since_id=", since_id, "&max_id=", max_id, "&trim_user=", trim_user, "&exclude_replies=", exclude_replies, "&contributor_details=", contributor_details, "&include_entities=", include_entities);
		}

        
		public virtual Task<HttpResponse<IEnumerable<TwitterStatus>>> ListRetweetsOfMyTweets(ListRetweetsOfMyTweetsOptions options)
		{
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var trim_user = options.TrimUser;
			var include_entities = options.IncludeEntities;
			var include_user_entities = options.IncludeUserEntities;
				
			
			return ExecuteRequest<IEnumerable<TwitterStatus>>("statuses/retweets_of_me", FormatAsString, "?count=", count, "&since_id=", since_id, "&max_id=", max_id, "&trim_user=", trim_user, "&include_entities=", include_entities, "&include_user_entities=", include_user_entities);
		}

        
		public virtual Task<HttpResponse<IEnumerable<TwitterStatus>>> Retweets(RetweetsOptions options)
		{
			var id = options.Id;
			var count = options.Count;
			var trim_user = options.TrimUser;
				
			
			return ExecuteRequest<IEnumerable<TwitterStatus>>("statuses/retweets/{id}", FormatAsString, "?id=", id, "&count=", count, "&trim_user=", trim_user);
		}

        
		public virtual Task<HttpResponse<TwitterStatus>> GetTweet(GetTweetOptions options)
		{
			var id = options.Id;
			var trim_user = options.TrimUser;
			var include_my_retweet = options.IncludeMyRetweet;
			var include_entities = options.IncludeEntities;
				
			
			return ExecuteRequest<TwitterStatus>("statuses/show/{id}", FormatAsString, "?id=", id, "&trim_user=", trim_user, "&include_my_retweet=", include_my_retweet, "&include_entities=", include_entities);
		}

        
		public virtual Task<HttpResponse<TwitterStatus>> DeleteTweet(DeleteTweetOptions options)
		{
			var id = options.Id;
			var trim_user = options.TrimUser;
				
			
			return ExecuteRequest<TwitterStatus>(HttpMethod.Delete, "statuses/destroy/{id}", FormatAsString, "?id=", id, "&trim_user=", trim_user);
		}

        
		public virtual Task<HttpResponse<TwitterStatus>> SendTweet(SendTweetOptions options)
		{
			var status = options.Status;
			var in_reply_to_status_id = options.InReplyToStatusId;
			var lat = options.Lat;
			var @long = options.@Long;
			var place_id = options.PlaceId;
			var display_coordinates = options.DisplayCoordinates;
			var trim_user = options.TrimUser;
				
			
			return ExecuteRequest<TwitterStatus>(HttpMethod.Post, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", in_reply_to_status_id, "&lat=", lat, "&long=", @long, "&place_id=", place_id, "&display_coordinates=", display_coordinates, "&trim_user=", trim_user);
		}

        
		public virtual Task<HttpResponse<TwitterStatus>> Retweet(RetweetOptions options)
		{
			var id = options.Id;
			var trim_user = options.TrimUser;
				
			
			return ExecuteRequest<TwitterStatus>(HttpMethod.Post, "statuses/retweet/{id}", FormatAsString, "?id=", id, "&trim_user=", trim_user);
		}

        
		public virtual Task<HttpResponse<TwitterStatus>> SendTweetWithMedia(SendTweetWithMediaOptions options)
		{
			var status = options.Status;
			var possibly_sensitive = options.PossiblySensitive;
			var in_reply_to_status_id = options.InReplyToStatusId;
			var lat = options.Lat;
			var @long = options.@Long;
			var place_id = options.PlaceId;
			var display_coordinates = options.DisplayCoordinates;
			 var images = options.Images;
				
			
			return ExecuteRequest<TwitterStatus>(HttpMethod.Post, "statuses/update_with_media", images, FormatAsString, "?status=", status, "&possibly_sensitive=", possibly_sensitive, "&in_reply_to_status_id=", in_reply_to_status_id, "&lat=", lat, "&long=", @long, "&place_id=", place_id, "&display_coordinates=", display_coordinates);
		}

        
		public virtual Task<HttpResponse<TwitterSearchResult>> Search(SearchOptions options)
		{
			var q = options.Q;
			var geocode = options.Geocode;
			var lang = options.Lang;
			var locale = options.Locale;
			var resultType = options.Resulttype;
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var include_entities = options.IncludeEntities;
			var callback = options.Callback;
				
			
			return ExecuteRequest<TwitterSearchResult>("search/tweets", FormatAsString, "?q=", q, "&geocode=", geocode, "&lang=", lang, "&locale=", locale, "&result_type=", resultType, "&count=", count, "&since_id=", since_id, "&max_id=", max_id, "&include_entities=", include_entities, "&callback=", callback);
		}

        
		public virtual Task<HttpResponse<IEnumerable<TwitterDirectMessage>>> ListDirectMessagesReceived(ListDirectMessagesReceivedOptions options)
		{
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var count = options.Count;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return ExecuteRequest<IEnumerable<TwitterDirectMessage>>("direct_messages", FormatAsString, "?since_id=", since_id, "&max_id=", max_id, "&count=", count, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual Task<HttpResponse<IEnumerable<TwitterDirectMessage>>> ListDirectMessagesSent(ListDirectMessagesSentOptions options)
		{
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var count = options.Count;
			var page = options.Page;
			var include_entities = options.IncludeEntities;
				
			
			return ExecuteRequest<IEnumerable<TwitterDirectMessage>>("direct_messages/sent", FormatAsString, "?since_id=", since_id, "&max_id=", max_id, "&count=", count, "&page=", page, "&include_entities=", include_entities);
		}

        
		public virtual Task<HttpResponse<TwitterDirectMessage>> GetDirectMessage(GetDirectMessageOptions options)
		{
			var id = options.Id;
				
			
			return ExecuteRequest<TwitterDirectMessage>("direct_messages/show", FormatAsString, "?id=", id);
		}

        
		public virtual Task<HttpResponse<TwitterDirectMessage>> DeleteDirectMessage(DeleteDirectMessageOptions options)
		{
			var id = options.Id;
			var include_entities = options.IncludeEntities;
				
			
			return ExecuteRequest<TwitterDirectMessage>(HttpMethod.Post, "direct_messages/destroy", FormatAsString, "?id=", id, "&include_entities=", include_entities);
		}

        
		public virtual Task<HttpResponse<TwitterDirectMessage>> SendDirectMessage(SendDirectMessageOptions options)
		{
			var text = options.Text;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
				
			
			return ExecuteRequest<TwitterDirectMessage>(HttpMethod.Post, "direct_messages/new", FormatAsString, "?text=", text, "&user_id=", user_id, "&screen_name=", screen_name);
		}

        
		public virtual Task<HttpResponse<TwitterCursorList<long>>> ListFriendIdsOf(ListFriendIdsOfOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var count = options.Count;
				
			
			return ExecuteRequest<TwitterCursorList<long>>("friends/ids", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&count=", count);
		}

        
		public virtual Task<HttpResponse<TwitterCursorList<long>>> ListFollowerIdsOf(ListFollowerIdsOfOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var count = options.Count;
				
			
			return ExecuteRequest<TwitterCursorList<long>>("followers/ids", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&count=", count);
		}

        
		public virtual Task<HttpResponse<IEnumerable<TwitterFriendshipLookup>>> ListFriendshipsFor(ListFriendshipsForOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
				
			
			return ExecuteRequest<IEnumerable<TwitterFriendshipLookup>>("friendships/lookup", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}

        
		public virtual Task<HttpResponse<TwitterCursorList<long>>> GetIncomingFriendRequests(GetIncomingFriendRequestsOptions options)
		{
			var cursor = options.Cursor;
				
			
			return ExecuteRequest<TwitterCursorList<long>>("friendships/incoming", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual Task<HttpResponse<TwitterCursorList<long>>> GetOutgoingFriendRequests(GetOutgoingFriendRequestsOptions options)
		{
			var cursor = options.Cursor;
				
			
			return ExecuteRequest<TwitterCursorList<long>>("friendships/outgoing", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual Task<HttpResponse<TwitterUser>> FollowUser(FollowUserOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var follow = options.Follow;
				
			
			return ExecuteRequest<TwitterUser>(HttpMethod.Post, "friendships/create", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&follow=", follow);
		}

        
		public virtual Task<HttpResponse<TwitterUser>> UnfollowUser(UnfollowUserOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
				
			
			return ExecuteRequest<TwitterUser>(HttpMethod.Post, "friendships/destroy", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}

        
		public virtual Task<HttpResponse<TwitterFriendship>> UpdateFriendship(UpdateFriendshipOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var device = options.Device;
			var retweets = options.Retweets;
				
			
			return ExecuteRequest<TwitterFriendship>(HttpMethod.Post, "friendships/update", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&device=", device, "&retweets=", retweets);
		}

        
		public virtual Task<HttpResponse<TwitterFriendship>> GetFriendshipInfo(GetFriendshipInfoOptions options)
		{
			var source_id = options.SourceId;
			var source_screen_name = options.SourceScreenName;
			var target_id = options.TargetId;
			var target_screen_name = options.TargetScreenName;
				
			
			return ExecuteRequest<TwitterFriendship>("friendships/show", FormatAsString, "?source_id=", source_id, "&source_screen_name=", source_screen_name, "&target_id=", target_id, "&target_screen_name=", target_screen_name);
		}

        
		public virtual Task<HttpResponse<TwitterCursorList<TwitterUser>>> ListFriends(ListFriendsOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var skip_status = options.SkipStatus;
			var include_user_entities = options.IncludeUserEntities;
				
			
			return ExecuteRequest<TwitterCursorList<TwitterUser>>("friends/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&skip_status=", skip_status, "&include_user_entities=", include_user_entities);
		}

        
		public virtual Task<HttpResponse<TwitterCursorList<TwitterUser>>> ListFollowers(ListFollowersOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var skip_status = options.SkipStatus;
			var include_user_entities = options.IncludeUserEntities;
				
			
			return ExecuteRequest<TwitterCursorList<TwitterUser>>("followers/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&skip_status=", skip_status, "&include_user_entities=", include_user_entities);
		}

        
		public virtual Task<HttpResponse<TwitterAccount>> GetAccountSettings()
		{
				
			
			return ExecuteRequest<TwitterAccount>("account/settings", FormatAsString);
		}

        
		public virtual Task<HttpResponse<TwitterUser>> GetUserProfile(GetUserProfileOptions options)
		{
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return ExecuteRequest<TwitterUser>("account/verify_credentials", FormatAsString, "?include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual Task<HttpResponse<TwitterUser>> VerifyCredentials(VerifyCredentialsOptions options)
		{
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return ExecuteRequest<TwitterUser>("account/verify_credentials", FormatAsString, "?include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual Task<HttpResponse<TwitterAccount>> UpdateAccountSettings(UpdateAccountSettingsOptions options)
		{
			var trend_location_woeid = options.TrendLocationWoeid;
			var sleep_time_enabled = options.SleepTimeEnabled;
			var start_sleep_time = options.StartSleepTime;
			var end_sleep_time = options.EndSleepTime;
			var time_zone = options.TimeZone;
			var lang = options.Lang;
				
			
			return ExecuteRequest<TwitterAccount>(HttpMethod.Post, "account/settings", FormatAsString, "?trend_location_woeid=", trend_location_woeid, "&sleep_time_enabled=", sleep_time_enabled, "&start_sleep_time=", start_sleep_time, "&end_sleep_time=", end_sleep_time, "&time_zone=", time_zone, "&lang=", lang);
		}

        
		public virtual Task<HttpResponse<TwitterUser>> UpdateDeliveryDevice(UpdateDeliveryDeviceOptions options)
		{
			var device = options.Device;
			var include_entities = options.IncludeEntities;
				
			
			return ExecuteRequest<TwitterUser>("account/update_delivery_device", FormatAsString, "?device=", device, "&include_entities=", include_entities);
		}

        
		public virtual Task<HttpResponse<TwitterUser>> UpdateProfile(UpdateProfileOptions options)
		{
			var name = options.Name;
			var url = options.Url;
			var location = options.Location;
			var description = options.Description;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return ExecuteRequest<TwitterUser>(HttpMethod.Post, "account/update_profile", FormatAsString, "?name=", name, "&url=", url, "&location=", location, "&description=", description, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual Task<HttpResponse<TwitterUser>> UpdateProfileBackgroundImage(UpdateProfileBackgroundImageOptions options)
		{
			var imagePath = options.Imagepath;
			var tile = options.Tile;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var use = options.Use;
				
			
			return ExecuteRequest<TwitterUser>(HttpMethod.Post, "account/update_profile_background_image", FormatAsString, "?image_path=", imagePath, "&tile=", tile, "&include_entities=", include_entities, "&skip_status=", skip_status, "&use=", use);
		}

        
		public virtual Task<HttpResponse<TwitterUser>> UpdateProfileColors(UpdateProfileColorsOptions options)
		{
			var profile_background_color = options.ProfileBackgroundColor;
			var profile_link_color = options.ProfileLinkColor;
			var profile_sidebar_border_color = options.ProfileSidebarBorderColor;
			var profile_sidebar_fill_color = options.ProfileSidebarFillColor;
			var profile_text_color = options.ProfileTextColor;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return ExecuteRequest<TwitterUser>(HttpMethod.Post, "account/update_profile_colors", FormatAsString, "?profile_background_color=", profile_background_color, "&profile_link_color=", profile_link_color, "&profile_sidebar_border_color=", profile_sidebar_border_color, "&profile_sidebar_fill_color=", profile_sidebar_fill_color, "&profile_text_color=", profile_text_color, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual Task<HttpResponse<TwitterUser>> UpdateProfileImage(UpdateProfileImageOptions options)
		{
			var image_path = options.ImagePath;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return ExecuteRequest<TwitterUser>(HttpMethod.Post, "account/update_profile_image", FormatAsString, "?image_path=", image_path, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual Task<HttpResponse<TwitterCursorList<TwitterUser>>> ListBlockedUsers(ListBlockedUsersOptions options)
		{
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
			var cursor = options.Cursor;
				
			
			return ExecuteRequest<TwitterCursorList<TwitterUser>>("blocks/list", FormatAsString, "?include_entities=", include_entities, "&skip_status=", skip_status, "&cursor=", cursor);
		}

        
		public virtual Task<HttpResponse<TwitterCursorList<long>>> ListBlockedUserIds(ListBlockedUserIdsOptions options)
		{
			var cursor = options.Cursor;
				
			
			return ExecuteRequest<TwitterCursorList<long>>("blocks/ids", FormatAsString, "?cursor=", cursor);
		}

        
		public virtual Task<HttpResponse<TwitterUser>> BlockUser(BlockUserOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return ExecuteRequest<TwitterUser>(HttpMethod.Post, "blocks/create", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual Task<HttpResponse<TwitterUser>> UnblockUser(UnblockUserOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return ExecuteRequest<TwitterUser>(HttpMethod.Post, "blocks/destroy", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual Task<HttpResponse<IEnumerable<TwitterUser>>> ListUserProfilesFor(ListUserProfilesForOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
			var include_entities = options.IncludeEntities;
				
			
			return ExecuteRequest<IEnumerable<TwitterUser>>("users/lookup", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id, "&include_entities=", include_entities);
		}

        
		public virtual Task<HttpResponse<TwitterUser>> GetUserProfileFor(GetUserProfileForOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var include_entities = options.IncludeEntities;
				
			
			return ExecuteRequest<TwitterUser>("users/show", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&include_entities=", include_entities);
		}

        
		public virtual Task<HttpResponse<IEnumerable<TwitterUser>>> SearchForUser(SearchForUserOptions options)
		{
			var q = options.Q;
			var page = options.Page;
			var count = options.Count;
			var include_entities = options.IncludeEntities;
				
			
			return ExecuteRequest<IEnumerable<TwitterUser>>("users/search", FormatAsString, "?q=", q, "&page=", page, "&count=", count, "&include_entities=", include_entities);
		}

        
		public virtual Task<HttpResponse<TwitterUserSuggestions>> ListSuggestedUsers(ListSuggestedUsersOptions options)
		{
			var slug = options.Slug;
			var lang = options.Lang;
				
			
			return ExecuteRequest<TwitterUserSuggestions>("/users/suggestions/{slug}", FormatAsString, "?slug=", slug, "&lang=", lang);
		}

        
		public virtual Task<HttpResponse<IEnumerable<TwitterUserSuggestions>>> ListSuggestedUserCategories(ListSuggestedUserCategoriesOptions options)
		{
			var lang = options.Lang;
				
			
			return ExecuteRequest<IEnumerable<TwitterUserSuggestions>>("users/suggestions", FormatAsString, "?lang=", lang);
		}

        
		public virtual Task<HttpResponse<IEnumerable<TwitterUser>>> GetSuggestedUserMembers(GetSuggestedUserMembersOptions options)
		{
			var slug = options.Slug;
				
			
			return ExecuteRequest<IEnumerable<TwitterUser>>("/users/suggestions/{slug}/members", FormatAsString, "?slug=", slug);
		}

        
		public virtual Task<HttpResponse<IEnumerable<TwitterStatus>>> ListFavoriteTweets(ListFavoriteTweetsOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var include_entities = options.IncludeEntities;
				
			
			return ExecuteRequest<IEnumerable<TwitterStatus>>("favorites/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&since_id=", since_id, "&max_id=", max_id, "&include_entities=", include_entities);
		}

        
		public virtual Task<HttpResponse<TwitterStatus>> UnfavoriteTweet(UnfavoriteTweetOptions options)
		{
			var id = options.Id;
				
			
			return ExecuteRequest<TwitterStatus>(HttpMethod.Post, "favorites/destroy", FormatAsString, "?id=", id);
		}

        
		public virtual Task<HttpResponse<TwitterStatus>> FavoriteTweet(FavoriteTweetOptions options)
		{
			var id = options.Id;
			var include_entities = options.IncludeEntities;
				
			
			return ExecuteRequest<TwitterStatus>(HttpMethod.Post, "favorites/create", FormatAsString, "?id=", id, "&include_entities=", include_entities);
		}

        
		public virtual Task<HttpResponse<IEnumerable<TwitterList>>> ListListsFor(ListListsForOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
				
			
			return ExecuteRequest<IEnumerable<TwitterList>>("lists/list", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name);
		}

        
		public virtual Task<HttpResponse<IEnumerable<TwitterStatus>>> ListTweetsOnList(ListTweetsOnListOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var since_id = options.SinceId;
			var max_id = options.MaxId;
			var count = options.Count;
			var include_entities = options.IncludeEntities;
			var include_rts = options.IncludeRts;
				
			
			return ExecuteRequest<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&since_id=", since_id, "&max_id=", max_id, "&count=", count, "&include_entities=", include_entities, "&include_rts=", include_rts);
		}

        
		public virtual Task<HttpResponse<TwitterUser>> RemoveListMember(RemoveListMemberOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
				
			
			return ExecuteRequest<TwitterUser>(HttpMethod.Post, "lists/members/destroy", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual Task<HttpResponse<TwitterCursorList<TwitterList>>> ListListMembershipsFor(ListListMembershipsForOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var cursor = options.Cursor;
			var filter_to_owned_lists = options.FilterToOwnedLists;
				
			
			return ExecuteRequest<TwitterCursorList<TwitterList>>("lists/memberships", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&cursor=", cursor, "&filter_to_owned_lists=", filter_to_owned_lists);
		}

        
		public virtual Task<HttpResponse<TwitterCursorList<TwitterUser>>> ListListSubscribers(ListListSubscribersOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var cursor = options.Cursor;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return ExecuteRequest<TwitterCursorList<TwitterUser>>("lists/subscribers", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&cursor=", cursor, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual Task<HttpResponse<TwitterUser>> FollowList(FollowListOptions options)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
				
			
			return ExecuteRequest<TwitterUser>(HttpMethod.Post, "lists/subscribers/create", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug);
		}

        
		public virtual Task<HttpResponse<TwitterUser>> VerifyListSubscription(VerifyListSubscriptionOptions options)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return ExecuteRequest<TwitterUser>("lists/subscribers/show", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual Task<HttpResponse<TwitterUser>> UnfollowList(UnfollowListOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
				
			
			return ExecuteRequest<TwitterUser>(HttpMethod.Post, "lists/subscribers/destroy", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual Task<HttpResponse<TwitterUser>> VerifyListMembership(VerifyListMembershipOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return ExecuteRequest<TwitterUser>("lists/members/show", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual Task<HttpResponse<TwitterCursorList<TwitterUser>>> ListListMembers(ListListMembersOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var cursor = options.Cursor;
			var include_entities = options.IncludeEntities;
			var skip_status = options.SkipStatus;
				
			
			return ExecuteRequest<TwitterCursorList<TwitterUser>>("lists/members", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&cursor=", cursor, "&include_entities=", include_entities, "&skip_status=", skip_status);
		}

        
		public virtual Task<HttpResponse<TwitterUser>> AddListMember(AddListMemberOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
				
			
			return ExecuteRequest<TwitterUser>(HttpMethod.Post, "lists/members/create", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&user_id=", user_id, "&screen_name=", screen_name, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual Task<HttpResponse<TwitterList>> DeleteList(DeleteListOptions options)
		{
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
			var list_id = options.ListId;
			var slug = options.Slug;
				
			
			return ExecuteRequest<TwitterList>(HttpMethod.Post, "lists/destroy", FormatAsString, "?owner_screen_name=", owner_screen_name, "&owner_id=", owner_id, "&list_id=", list_id, "&slug=", slug);
		}

        
		public virtual Task<HttpResponse<TwitterList>> CreateList(CreateListOptions options)
		{
			var list_owner = options.ListOwner;
			var name = options.Name;
			var mode = options.Mode;
			var description = options.Description;
				
			
			return ExecuteRequest<TwitterList>(HttpMethod.Post, "lists/create", FormatAsString, "?list_owner=", list_owner, "&name=", name, "&mode=", mode, "&description=", description);
		}

        
		public virtual Task<HttpResponse<TwitterList>> GetList(GetListOptions options)
		{
			var list_id = options.ListId;
			var slug = options.Slug;
			var owner_screen_name = options.OwnerScreenName;
			var owner_id = options.OwnerId;
				
			
			return ExecuteRequest<TwitterList>("lists/show", FormatAsString, "?list_id=", list_id, "&slug=", slug, "&owner_screen_name=", owner_screen_name, "&owner_id=", owner_id);
		}

        
		public virtual Task<HttpResponse<TwitterCursorList<TwitterList>>> ListSubscriptions(ListSubscriptionsOptions options)
		{
			var user_id = options.UserId;
			var screen_name = options.ScreenName;
			var count = options.Count;
			var cursor = options.Cursor;
				
			
			return ExecuteRequest<TwitterCursorList<TwitterList>>("lists/subscriptions", FormatAsString, "?user_id=", user_id, "&screen_name=", screen_name, "&count=", count, "&cursor=", cursor);
		}

        
		public virtual Task<HttpResponse<IEnumerable<TwitterSavedSearch>>> ListSavedSearches()
		{
				
			
			return ExecuteRequest<IEnumerable<TwitterSavedSearch>>("saved_searches/list", FormatAsString);
		}

        
		public virtual Task<HttpResponse<TwitterSavedSearch>> GetSavedSearch(GetSavedSearchOptions options)
		{
			var id = options.Id;
				
			
			return ExecuteRequest<TwitterSavedSearch>("saved_searches/show/{id}", FormatAsString, "?id=", id);
		}

        
		public virtual Task<HttpResponse<TwitterSavedSearch>> CreateSavedSearch(CreateSavedSearchOptions options)
		{
			var query = options.Query;
				
			
			return ExecuteRequest<TwitterSavedSearch>(HttpMethod.Post, "saved_searches/create", FormatAsString, "?query=", query);
		}

        
		public virtual Task<HttpResponse<TwitterSavedSearch>> DeleteSavedSearch(DeleteSavedSearchOptions options)
		{
			var id = options.Id;
				
			
			return ExecuteRequest<TwitterSavedSearch>(HttpMethod.Post, "saved_searches/destroy/{id}", FormatAsString, "?id=", id);
		}

        
		public virtual Task<HttpResponse<TwitterPlace>> GetPlace(GetPlaceOptions options)
		{
			var place_id = options.PlaceId;
				
			
			return ExecuteRequest<TwitterPlace>("geo/id/{place_id}", FormatAsString, "?place_id=", place_id);
		}

        
		public virtual Task<HttpResponse<IEnumerable<TwitterPlace>>> ReverseGeocode(ReverseGeocodeOptions options)
		{
			var lat = options.Lat;
			var @long = options.@Long;
			var accuracy = options.Accuracy;
			var granularity = options.Granularity;
			var max_results = options.MaxResults;
			var callback = options.Callback;
				
			
			return ExecuteRequest<IEnumerable<TwitterPlace>>("geo/reverse_geocode", FormatAsString, "?lat=", lat, "&long=", @long, "&accuracy=", accuracy, "&granularity=", granularity, "&max_results=", max_results, "&callback=", callback);
		}

        
		public virtual Task<HttpResponse<IEnumerable<TwitterPlace>>> GeoSearch(GeoSearchOptions options)
		{
			var lat = options.Lat;
			var @long = options.@Long;
			var query = options.Query;
			var ip = options.Ip;
			var granularity = options.Granularity;
			var accuracy = options.Accuracy;
			var max_results = options.MaxResults;
			var contained_within = options.ContainedWithin;
			var callback = options.Callback;
				
			
			return ExecuteRequest<IEnumerable<TwitterPlace>>("geo/search", FormatAsString, "?lat=", lat, "&long=", @long, "&query=", query, "&ip=", ip, "&granularity=", granularity, "&accuracy=", accuracy, "&max_results=", max_results, "&contained_within=", contained_within, "&callback=", callback);
		}

        
		public virtual Task<HttpResponse<TwitterTrends>> ListLocalTrendsFor(ListLocalTrendsForOptions options)
		{
			var id = options.Id;
			var exclude = options.Exclude;
				
			
			return ExecuteRequest<TwitterTrends>("trends/place", FormatAsString, "?id=", id, "&exclude=", exclude);
		}

        
		public virtual Task<HttpResponse<IEnumerable<WhereOnEarthLocation>>> ListAvailableTrendsLocations()
		{
				
			
			return ExecuteRequest<IEnumerable<WhereOnEarthLocation>>("trends/available", FormatAsString);
		}

        
		public virtual Task<HttpResponse<IEnumerable<WhereOnEarthLocation>>> ListClosestTrendsLocations(ListClosestTrendsLocationsOptions options)
		{
			var lat = options.Lat;
			var @long = options.@Long;
				
			
			return ExecuteRequest<IEnumerable<WhereOnEarthLocation>>("trends/closest", FormatAsString, "?lat=", lat, "&long=", @long);
		}

        
		public virtual Task<HttpResponse<TwitterRateLimitStatusSummary>> GetRateLimitStatus(GetRateLimitStatusOptions options)
		{
			var resources = options.Resources;
				
			
			return ExecuteRequest<TwitterRateLimitStatusSummary>("application/rate_limit_status", FormatAsString, "?resources=", resources);
		}

        
		public virtual Task<HttpResponse<TwitterUser>> ReportSpam(ReportSpamOptions options)
		{
			var screen_name = options.ScreenName;
			var user_id = options.UserId;
				
			
			return ExecuteRequest<TwitterUser>(HttpMethod.Post, "users/report_spam", FormatAsString, "?screen_name=", screen_name, "&user_id=", user_id);
		}

		#endregion
	}
	#endregion
}