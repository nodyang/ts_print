namespace TsProject
{
    public class AppHeadType
    {
        /// <summary>
        /// 第一次导入为空，导入成功后返回预录入编号；第二次导入填写返回的预录入编号
        /// </summary>
        public string SEQ_NO { get; set; }
        /// <summary>
        /// 申报表编号
        /// </summary>
        public string SAS_DCL_NO { get; set; }
        /// <summary>
        /// 主管关区代码
        /// </summary>
        public string MASTER_CUSCD { get; set; }
        /// <summary>
        /// 申报类型代码
        /// </summary>
        public string DCL_TYPECD { get; set; }
        /// <summary>
        /// 业务类型代码
        /// </summary>
        public string BUSINESS_TYPECD { get; set; }
        
        /// <summary>
        /// 货物流向代码
        /// </summary>
        public string DIRECTION_TYPECD { get; set; }
        /// <summary>
        /// 区内账册编号
        /// </summary>
        public string AREAIN_ORIACT_NO { get; set; }
        /// <summary>
        /// 区外账册编号
        /// </summary>
        public string AREAOUT_ORIACT_NO { get; set; }
        /// <summary>
        /// 区内企业编码
        /// </summary>
        public string AREAIN_ETPSNO { get; set; }
        /// <summary>
        /// 区内企业名称
        /// </summary>
        public string AREAIN_ETPS_NM { get; set; }
        /// <summary>
        /// 区内企业社会信用代码
        /// </summary>
        public string AREAIN_ETPS_SCCD { get; set; }
        /// <summary>
        /// 区外企业编码
        /// </summary>
        public string AREAOUT_ETPSNO { get; set; }
        /// <summary>
        /// 区外企业名称	an..512
        /// </summary>
        public string AREAOUT_ETPS_NM { get; set; }
        /// <summary>
        /// 区外企业社会信用代码
        /// </summary>
        public string AREAOUT_ETPS_SCCD { get; set; }
        /// <summary>
        /// 保证金征收单编号
        /// </summary>
        public string DPST_LEVY_BL_NO { get; set; }
        /// <summary>
        /// 有效期
        /// </summary>
        public string VALID_TIME { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string DCL_ER { get; set; }
        /// <summary>
        /// 展示地
        /// </summary>
        public string EXHIBITION_PLACE { get; set; }
        /// <summary>
        /// 申报企业编号
        /// </summary>
        public string DCL_ETPSNO { get; set; }
        /// <summary>
        /// 申报企业名称
        /// </summary>
        public string DCL_ETPS_NM { get; set; }
        /// <summary>
        ///  申报企业社会信用代码
        /// </summary>
        public string DCL_ETPS_SCCD { get; set; }
        /// <summary>
        /// 录入单位代码
        /// </summary>
        public string INPUT_CODE { get; set; }
        /// <summary>
        /// 录入单位社会信用代码
        /// </summary>
        public string INPUT_SCCD { get; set; }
        /// <summary>
        /// 录入单位名称
        /// </summary>
        public string INPUT_NAME { get; set; }
        /// <summary>
        /// 企业内部编号
        /// </summary>
        public string ETPS_PREENT_NO { get; set; }
        /// <summary>
        /// 底账料件成品标志
        /// </summary>
        public string MTPCK_ENDPRD_TYPECD { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string RMK { get; set; }
        /// <summary>
        /// 边角料标志
        /// </summary>
        public string Col1 { get; set; }
        /// <summary>
        /// 备用字段2
        /// </summary>
        public string Col2 { get; set; }
        /// <summary>
        /// 备用字段3
        /// </summary>
        public string Col3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Col4 { get; set; }
        /// <summary>
        /// 保税区内销标志
        /// </summary>
        public string FreeDomestic { get; set; }
     
      
    }
}