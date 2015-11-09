using System;
using VkNet.Utils;

namespace VkNet.Model.Attachments
{
    [Serializable]
	/// <summary>
    /// ������� ����������.
    /// ��. �������� <see href="http://vk.com/dev/attachments_w"/>. ������ "������� ����������".
    /// </summary>
    public class ApplicationContent
    {
        /// <summary>
        /// ������������� ����������, ������������� ������ �� �����.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// �������� ����������.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ����� ����������� ��� �������������.
        /// </summary>
        public string Photo130 { get; set; }

        /// <summary>
        /// ����� ��������������� �����������. 
        /// </summary>
        public string Photo604 { get; set; }

		#region ������
		/// <summary>
		/// ��������� �� json.
		/// </summary>
		/// <param name="response">����� �������.</param>
		/// <returns></returns>
		internal static ApplicationContent FromJson(VkResponse response)
        {
	        var application = new ApplicationContent
	        {
		        Id = response["id"],
		        Name = response["name"],
		        Photo130 = response["photo_130"],
		        Photo604 = response["photo_604"]
	        };


	        return application;
        }

        #endregion
    }
}