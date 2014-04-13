using VkNet.Utils;

namespace VkNet.Enums
{
	/// <summary>
	/// ������� ���������
	/// </summary>
	public class CountersFilter : VkFilter
	{
		/// <summary>
		/// ���������� ������ � ������
		/// </summary>
		public static readonly CountersFilter Friends = new CountersFilter(1 << 0, "friends");
		/// <summary>
		/// ���������� ������������� ���������
		/// </summary>
		public static readonly CountersFilter Messages = new CountersFilter(1 << 1, "messages");
		/// <summary>
		/// ���������� ����
		/// </summary>
		public static readonly CountersFilter Photos = new CountersFilter(1 << 2, "photos");
		/// <summary>
		/// ���������� �����
		/// </summary>
		public static readonly CountersFilter Videos = new CountersFilter(1 << 3, "videos");
		/// <summary>
		/// ���������� �������
		/// </summary>
		public static readonly CountersFilter Notes = new CountersFilter(1 << 4, "notes");
		/// <summary>
		/// ���������� ��������
		/// </summary>
		public static readonly CountersFilter Gifts = new CountersFilter(1 << 5, "gifts");
		/// <summary>
		/// ���������� �������
		/// </summary>
		public static readonly CountersFilter Events = new CountersFilter(1 << 6, "events");
		/// <summary>
		/// ���������� �����
		/// </summary>
		public static readonly CountersFilter Groups = new CountersFilter(1 << 7, "groups");
		/// <summary>
		/// ���������� �����������
		/// </summary>
		public static readonly CountersFilter Notifications = new CountersFilter(1 << 8, "notifications");
		
		/// <summary>
		/// ��� �������
		/// </summary>
		public static readonly CountersFilter All = Friends | Messages | Photos | Videos
			| Notes | Gifts | Events | Groups | Notifications;

		private CountersFilter(long value, string name)
			: base(value, name)
		{

		}

		private CountersFilter(CountersFilter left, CountersFilter right)
			: base(left, right)
		{

		}

		/// <summary>
		/// �������� ����������� ����� �������.
		/// </summary>
		/// <param name="left">����� ���� ��������� �����������.</param>
		/// <param name="right">������ ���� ��������� �����������.</param>
		/// <returns>��������� �����������.</returns>
		public static CountersFilter operator |(CountersFilter left, CountersFilter right)
		{
			return new CountersFilter(left, right);
		}
	}
}