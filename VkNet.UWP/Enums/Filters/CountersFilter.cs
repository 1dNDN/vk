namespace VkNet.Enums.Filters
{
	/// <summary>
	/// ������� ���������
	/// </summary>
	public sealed class CountersFilter : MultivaluedFilter<CountersFilter>
	{
        /// <summary>
        /// ���������� ������ � ������
        /// </summary>
        public static readonly CountersFilter Friends = RegisterPossibleValue("friends");

        /// <summary>
        /// ������������ ������
        /// </summary>
        public static readonly CountersFilter FriendsSuggestions = RegisterPossibleValue("friends_suggestions");

        /// <summary>
        /// ���������� ������������� ���������
        /// </summary>
        public static readonly CountersFilter Messages = RegisterPossibleValue("messages");

        /// <summary>
        /// ���������� ����
        /// </summary>
        public static readonly CountersFilter Photos = RegisterPossibleValue("photos");

        /// <summary>
        /// ���������� �����
        /// </summary>
        public static readonly CountersFilter Videos = RegisterPossibleValue("videos");

        /// <summary>
        /// ���������� ��������
        /// </summary>
        public static readonly CountersFilter Gifts = RegisterPossibleValue("gifts");

        /// <summary>
        /// ���������� �������
        /// </summary>
        public static readonly CountersFilter Events = RegisterPossibleValue("events");

        /// <summary>
        /// ���������� �����
        /// </summary>
        public static readonly CountersFilter Groups = RegisterPossibleValue("groups");

        /// <summary>
        /// ���������� �����������
        /// </summary>
        public static readonly CountersFilter Notifications = RegisterPossibleValue("notifications");

        /// <summary>
        /// ���������� �����������
        /// </summary>
        public static readonly CountersFilter Sdk = RegisterPossibleValue("sdk");

        /// <summary>
        /// ���������� �����������
        /// </summary>
        public static readonly CountersFilter AppRequests = RegisterPossibleValue("app_requests");

        /// <summary>
        /// ��� �������
        /// </summary>
        public static readonly CountersFilter All = Friends | FriendsSuggestions | Messages | Photos | Videos | Gifts | Events | Groups | Notifications | Sdk | AppRequests;
    }
}