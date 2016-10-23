using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VVPosM1.Common
{
    class Messages
    {
        /// <summary>
        /// Define title informtion message box
        /// </summary>
        public static string msgTitleInformation = "Thông báo";

        /// <summary>
        /// Define title information message box error
        /// </summary>
        public static string msgTitleError = "Lỗi";

        /// <summary>
        /// Define message error empty of member number (member id)
        /// </summary>
        public static string msgEmptyMemberNumber = "Vui lòng nhập vào mã khách hàng!";

        /// <summary>
        /// Define message error not exist of member number (member id)
        /// </summary>
        public static string msgNotExistMemberNumber = "Mã khách hàng không tồn tại trong hệ thống!";

        /// <summary>
        /// Define message error format member number (member id)
        /// </summary>
        public static string msgErrorFormatMemberNumber = "Mã khách hàng sai định dạng. Chỉ nhập số!";

        /// <summary>
        /// Define message error empty of customer name
        /// </summary>
        public static string msgEmptyCustomerName = "Vui lòng nhập tên khách hàng!";

        /// <summary>
        /// Define message error empty of customer phone
        /// </summary>
        public static string msgEmptyCustomerPhone = "Vui lòng nhập số điện thoại khách hàng!";

        /// <summary>
        /// Define message error format of customer phone
        /// </summary>
        public static string msgErrorFormatCustomerPhone = "Số điện thoại không chính xác!";

        /// <summary>
        /// Define message error empty of bracelet number
        /// </summary>
        public static string msgEmptyBraceletNumber = "Vui lòng nhập mã vòng đeo tay!";

        /// <summary>
        /// Define message error format of bracelet number
        /// </summary>
        public static string msgErrorFormatBraceletNumber = "Mã vòng đeo tay sai định dạng!";

        /// <summary>
        /// Define message error empty regist service when user not fill full information to regist services
        /// </summary>
        public static string msgEmptyRegistService = "Vui lòng nhập đầy đủ thông tin trước khi chọn đăng ký!";

        /// <summary>
        /// Define message error check sum bracelet number
        /// </summary>
        public static string msgCheckSumBraceletNumber = "Mã vòng đeo tay không đúng!";

        /// <summary>
        /// Define message error not exist bracelet number
        /// </summary>
        public static string msgNotExistBraceletNumber = "Mã vòng đeo tay này không tồn tại trong hệ thống!";

        /// <summary>
        /// Define message error the color of bracelet number not match with the color of services
        /// </summary>
        public static string msgBraceletNumberColorNotMatchColorServices = "Vòng đeo tay này không thuộc dịch vụ đã chọn!";

        /// <summary>
        /// Define message regist services successfully
        /// </summary>
        public static string msgSuccessRegist = "Đăng ký dịch vụ thành công";

        /// <summary>
        /// Define message error exist customer is using services
        /// </summary>
        public static string msgExistCustomerIsUsingServices = "Khách hàng đang sử dụng dịch vụ!";

        /// <summary>
        /// Define message error bracelet in used status
        /// </summary>
        public static string msgBraceletUsedStatus = "Vòng đeo tay hiện tại đang được sử dụng!";

        /// <summary>
        /// Define message error bracelet in loss status
        /// </summary>
        public static string msgBraceletLossStatus = "Vòng đeo tay này đã mất!";

        /// <summary>
        /// Define message error bracelet in unused status
        /// </summary>
        public static string msgBraceletUnUsedStatus = "Không tồn tại khách hàng sử dụng vòng đeo tay này!";

        /// <summary>
        /// Define message error cancel service failure
        /// </summary>
        public static string msgCancelServicesFailure = "Hủy dịch vụ thất bại!";

        /// <summary>
        /// Define message error cancel service success
        /// </summary>
        public static string msgCancelServicesSucess = "Hủy dịch vụ thành công!";

        /// <summary>
        /// Define message not yet scan bracelet number
        /// </summary>
        public static string msgNotYetScanBraceletNumber = "Chưa quét vòng tay!";

        /// <summary>
        /// Define message allow cancel services
        /// </summary>
        public static string msgAllowCancelServices = "Cho phép hủy!";

        /// <summary>
        /// Define message not allow cancel servoces
        /// </summary>
        public static string msgNotAllowCancelServices = "Không cho phép hủy!";

        /// <summary>
        /// Define message not fill total score
        /// </summary>
        public static string msgFillTotalScore = "Vui lòng nhập đầy đủ thông tin tổng số điểm!";

        /// <summary>
        /// Define message birthdate more than or equal 18 years old.
        /// </summary>
        public static string msgWrongBirthDate = "Vui lòng nhập đúng ngày sinh!";

        /// <summary>
        /// Define message error empty of email
        /// </summary>
        public static string msgEmptyEmail = "Vui lòng nhập địa chỉ hộp thư điện tử!";

        /// <summary>
        /// Define message error format of email
        /// </summary>
        public static string msgErrorFormatEmail = "Địa chỉ hộp thư điện tử không chính xác!";

        /// <summary>
        /// Define message empty of nationality
        /// </summary>
        public static string msgEmptyNationality = "Vui lòng nhập quốc tịch!";

        /// <summary>
        /// Define message error format of number
        /// </summary>
        public static string msgErrorFormatNumber = "Vui lòng chỉ nhập số!";

        /// <summary>
        /// Define message are you sure to delete?
        /// </summary>
        public static string msgAreYouSureDelete = "Bạn chắc chắn muốn xóa!";

        /// <summary>
        /// Define message error member is locked
        /// </summary>
        public static string msgErrorMemberCodeIsLock = "Khách hàng này đã bị khóa!";
    }
}
