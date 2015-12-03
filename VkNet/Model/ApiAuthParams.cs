using System;
using VkNet.Enums.Filters;

namespace VkNet
{
	/// <summary>
	/// ��������� �����������
	/// </summary>
	public struct ApiAuthParams
	{
		/// <summary>
		/// ������������� ���������� ��� �����������
		/// </summary>
		public ulong ApplicationId { get; set; }
		/// <summary>
		/// ����� ������������
		/// </summary>
		public string Login { get; set; }
		/// <summary>
		/// ������ ������������
		/// </summary>
		public string Password { get; set; }
		/// <summary>
		/// ����� ������� ����������
		/// </summary>
		public Settings Settings { get; set; }
		/// <summary>
		/// ������� ��������� ���� ��� ������������� �����������
		/// </summary>
		public Func<string> TwoFactorAuthorization { get; set; }
		/// <summary>
		/// ������������� ����� (���� ����������)
		/// </summary>
		public long? CaptchaSid { get; set; }
		/// <summary>
		/// ����� ����� (���� ����������)
		/// </summary>
		public string CaptchaKey { get; set; }

	}
}