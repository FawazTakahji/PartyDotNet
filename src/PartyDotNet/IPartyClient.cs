using PartyDotNet.Enums;
using PartyDotNet.Models;
using PartyDotNet.Models.Discord;
using PartyDotNet.Models.Pixiv;
using Refit;

namespace PartyDotNet;

public interface IPartyClient
{
    // Creators

    /// <summary>
    /// Retrieves a list of all creators.
    /// </summary>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// </remarks>
    [Get("/creators.txt")]
    public Task<List<Creator>> GetCreators();

    /// <summary>
    /// Retrieves a list of a creator's posts.
    /// </summary>
    /// <param name="offset">Result offset, with a stepping of 50 required.</param>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// <br />
    /// 400 - Offset is not a multiple of 50
    /// <br />
    /// 404 - Creator not found
    /// </remarks>
    /// <returns>
    /// An empty list if:
    /// <br />
    /// - Offset is too big
    /// <br />
    /// - The creator has no posts
    /// <br />
    /// - The creator doesn't exist
    /// </returns>
    [Get("/{service}/user/{creatorId}")]
    public Task<List<CreatorPost>> GetCreatorPosts(Service service, string creatorId, [AliasAs("o")] int offset = 0);

    /// <summary>
    /// Retrieves a list of a creator's posts matching the query in their title or content.
    /// </summary>
    /// <param name="offset">Result offset, with a stepping of 50 required.</param>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// <br />
    /// 400 - Offset is not a multiple of 50
    /// <br />
    /// 404 - Creator not found
    /// </remarks>
    /// <returns>
    /// An empty list if:
    /// <br />
    /// - No posts match the query
    /// <br />
    /// - Offset is too big
    /// <br />
    /// - The creator has no posts
    /// <br />
    /// - The creator doesn't exist
    /// </returns>
    [Get("/{service}/user/{creatorId}")]
    public Task<List<CreatorPost>> SearchCreatorPosts(Service service, string creatorId, [AliasAs("q")] string query, [AliasAs("o")] int offset = 0);

    /// <summary>
    /// Retrieves a list of a creator's announcements.
    /// </summary>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// <br />
    /// 404 - Creator not found
    /// </remarks>
    /// <returns>An empty list if the creator has no announcements.</returns>
    [Get("/{service}/user/{creatorId}/announcements")]
    public Task<List<Announcement>> GetCreatorAnnouncements(Service service, string creatorId);

    /// <summary>
    /// Retrieves a list of a creator's fancards (fanbox only).
    /// </summary>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// <br />
    /// 404 - Creator not found
    /// </remarks>
    /// <returns>An empty list if the creator has no fancards.</returns>
    [Get("/fanbox/user/{creatorId}/fancards")]
    public Task<List<FanCard>> GetCreatorFanCards(string creatorId);

    /// <summary>
    /// Retrieves a creator's profile.
    /// </summary>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// <br />
    /// 404 - Creator not found
    /// </remarks>
    [Get("/{service}/user/{creatorId}/profile")]
    public Task<Profile> GetCreatorProfile(Service service, string creatorId);

    /// <summary>
    /// Retrieves a list of a creator's linked accounts.
    /// </summary>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// <br />
    /// 404 - Creator not found
    /// </remarks>
    /// <returns>An empty list if the creator has no linked accounts or doesn't exist.</returns>
    [Get("/{service}/user/{creatorId}/links")]
    public Task<List<Profile>> GetCreatorLinks(Service service, string creatorId);


    // Posts

    /// <summary>
    /// Retrieves a list of recent posts.
    /// </summary>
    /// <param name="offset">Result offset, with a stepping of 50 required.</param>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// <br />
    /// 400 - Offset is not a multiple of 50 or is too big
    /// </remarks>
    [Get("/posts")]
    public Task<List<Post>> GetRecentPosts([AliasAs("o")] int offset = 0);

    /// <summary>
    /// Retrieves a list of posts matching the query in their title or content.
    /// </summary>
    /// <param name="offset">Result offset, with a stepping of 50 required.</param>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// <br />
    /// 400 - Offset is not a multiple of 50 or is too big
    /// </remarks>
    /// <returns>An empty list if no posts match the query.</returns>
    [Get("/posts")]
    public Task<List<Post>> SearchPosts([AliasAs("q")] string query, [AliasAs("o")] int offset = 0);

    /// <summary>
    /// Retrieves a specific post.
    /// </summary>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// <br />
    /// 404 - Post not found
    /// </remarks>
    [Get("/{service}/user/{creatorId}/post/{postId}")]
    public Task<CreatorPost> GetPost(Service service, string creatorId, string postId);

    /// <summary>
    /// Retrieves a list of a specific post's revisions.
    /// </summary>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// <br />
    /// 404 - Post not found or has no revisions
    /// </remarks>
    [Get("/{service}/user/{creatorId}/post/{postId}/revisions")]
    public Task<List<RevisionPost>> GetPostRevisions(Service service, string creatorId, string postId);

    /// <summary>
    /// Retrieves a list of a specific post's comments.
    /// </summary>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// <br />
    /// 404 - Post not found or has no comments
    /// </remarks>
    [Get("/{service}/user/{creatorId}/post/{postId}/comments")]
    public Task<List<Comment>> GetPostComments(Service service, string creatorId, string postId);

    /// <summary>
    /// Flags a post.
    /// </summary>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 201 - Post successfully flagged
    /// <br />
    /// 409 - Post is already flagged
    /// </remarks>
    [Post("/{service}/user/{creatorId}/post/{postId}/flag")]
    public Task<HttpResponseMessage> FlagPost(Service service, string creatorId, string postId);

    /// <summary>
    /// Checks if a post is flagged.
    /// </summary>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Post is flagged
    /// <br />
    /// 404 - Post is not flagged
    /// </remarks>
    [Get("/{service}/user/{creatorId}/post/{postId}/flag")]
    public Task<HttpResponseMessage> CheckPostFlagStatus(Service service, string creatorId, string postId);


    // Discord

    /// <summary>
    /// Retrieves a list of messages for a Discord channel.
    /// </summary>
    /// <param name="offset">Result offset, with a stepping of 150 required.</param>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// <br />
    /// 400 - Offset is not a multiple of 150
    /// <br />
    /// 404 - Channel not found
    /// </remarks>
    /// <returns>An empty list if the channel doesn't exist, or the offset is too big.</returns>
    [Get("/discord/channel/{channelId}")]
    public Task<List<Message>> GetChannelMessages(string channelId, [AliasAs("o")] int offset = 0);

    /// <summary>
    /// Retrieves a list of channels for a Discord server.
    /// </summary>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// <br />
    /// 404 - Server not found
    /// </remarks>
    /// <returns>An empty list if the server doesn't exist.</returns>
    [Get("/discord/channel/lookup/{serverId}")]
    public Task<List<Channel>> GetServerChannels(string serverId);


    // Favorites

    /// <summary>
    /// Retrieves a list of the account's favorite creators.
    /// </summary>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// <br />
    /// 401 - Unauthorized access
    /// </remarks>
    [Get("/account/favorites?type=artist")]
    public Task<List<FavoriteCreator>> GetFavoriteCreators();

    /// <summary>
    /// Retrieves a list of the account's favorite posts.
    /// </summary>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// <br />
    /// 401 - Unauthorized access
    /// </remarks>
    [Get("/account/favorites?type=post")]
    public Task<List<FavoritePost>> GetFavoritePosts();

    /// <summary>
    /// Adds a post to the account's favorites.
    /// </summary>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// <br />
    /// 302 - Redirect to login if not authenticated
    /// <br />
    /// 401 - Unauthorized access
    /// </remarks>
    [Post("/favorites/post/{service}/{creatorId}/{postId}")]
    public Task<HttpResponseMessage> AddFavoritePost(Service service, string creatorId, string postId);

    /// <summary>
    /// Removes a post from the account's favorites.
    /// </summary>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// <br />
    /// 302 - Redirect to login if not authenticated
    /// <br />
    /// 401 - Unauthorized access
    /// </remarks>
    [Delete("/favorites/post/{service}/{creatorId}/{postId}")]
    public Task<HttpResponseMessage> RemoveFavoritePost(Service service, string creatorId, string postId);

    /// <summary>
    /// Adds a creator to the account's favorites.
    /// </summary>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// <br />
    /// 302 - Redirect to login if not authenticated
    /// <br />
    /// 401 - Unauthorized access
    /// </remarks>
    [Post("/favorites/creator/{service}/{creatorId}")]
    public Task<HttpResponseMessage> AddFavoriteCreator(Service service, string creatorId);

    /// <summary>
    /// Removes a creator from the account's favorites
    /// </summary>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// <br />
    /// 302 - Redirect to login if not authenticated
    /// <br />
    /// 401 - Unauthorized access
    /// </remarks>
    [Delete("/favorites/creator/{service}/{creatorId}")]
    public Task<HttpResponseMessage> RemoveFavoriteCreator(Service service, string creatorId);

    // Misc

    /// <summary>
    /// Retrieves posts and Discord messages containing a specific file by its hash.
    /// </summary>
    /// <param name="hash">The SHA2/SHA256 hash of the file.</param>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - File found
    /// <br />
    /// 400 - Invalid hash
    /// <br />
    /// 404 - File not found
    /// </remarks>
    [Get("/search_hash/{hash}")]
    public Task<SearchResult> SearchHash(string hash);

    /// <summary>
    /// Retrieves the current app's Git commit hash.
    /// </summary>
    /// <remarks>
    /// Responses:
    /// <br />
    /// 200 - Success
    /// </remarks>
    [Get("/app_version")]
    public Task<string> GetAppVersion();
}