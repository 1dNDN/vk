namespace VkNet.Model.Attachments
{
	/// <summary>
	/// ����������� ������, ������� ������������� � ���������.
	/// </summary>
	public abstract class MediaAttachment
	{
		protected static string type;

		/// <summary>
		/// ������������� ������������ �������.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// ������������� ��������� ������������ �������.
		/// </summary>
		public long? OwnerId { get; set; }

		public override string ToString()
		{
			return string.Format("{0}{1}_{2}", type, OwnerId, Id);
		}
	}
}