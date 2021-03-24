namespace TsProject
{
    public class AppGoodsType
    {
        /// <summary>
        /// 申报表预录入编号
        /// </summary>
        public string SEQ_NO { get; set; }
        /// <summary>
        /// 申报表编号
        /// </summary>
        public string SAS_DCL_NO { get; set; }
        /// <summary>
        /// 申报序号
        /// </summary>
        public string SAS_DCL_SEQNO { get; set; }
        /// <summary>
        /// 底账商品序号
        /// </summary>
        public string ORIACT_GDS_SEQNO { get; set; }
        /// <summary>
        /// 料件成品标志
        /// </summary>
        public string MTPCK_END { get; set; }
        /// <summary>
        /// 代码
        /// </summary>
        public string PRD_TYPECD { get; set; }
        /// <summary>
        /// 商品编码
        /// </summary>
        public string GDECD { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GDS_NM { get; set; }
        /// <summary>
        /// 商品规格型号描述
        /// </summary>
        public string GDS_SPCF_MODEL_DESC { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public string DCL_QTY { get; set; }
        /// <summary>
        /// 申报计量单位代码
        /// </summary>
     
        public string DCL_UNITCD { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public string DCL_UPRC_AMT { get; set; }
        /// <summary>
        /// 总价
        /// </summary>
        public string DCL_TOTAL_AMT { get; set; }
        /// <summary>
        /// 币制代码
        /// </summary>
        public string DCL_CURRCD { get; set; }
        /// <summary>
        /// 许可证编号
        /// </summary>
        public string LICENCE_NO { get; set; }
        /// <summary>
        /// 许可证有效期
        /// </summary>
        public string LICENCE_VALID_TIME { get; set; }
        /// <summary>
        /// 商品标记代码
        /// </summary>
        public string GDS_MARKCD { get; set; }
        /// <summary>
        /// 商品备注
        /// </summary>
        public string GDS_RMK { get; set; }
        /// <summary>
        /// 修改标志代码
        /// </summary>
        public string MODF_MARKCD { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string RMK { get; set; }
        /// <summary>
        /// 商品料号 
        /// </summary>
        
        public string GDS_MTNO { get; set; }
      
        /// <summary>
        /// 法定计量单位代码 
        /// </summary>
        public string LAWF_UNITCD { get; set; }
      
        
        /// <summary>
        /// 法定第二计量代码 
        /// </summary>
        public string SECD_LAWF_UNITCD { get; set; }
        
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
        /// 成品类型
        /// </summary>
        public string EndprdGdsTypecd { get; set; }
       
    }
}