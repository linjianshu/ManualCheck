using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QualityCheckDemo
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model")
        {
        }

        public DateTime GetServerDate()
        {
            return Database.SqlQuery<DateTime>("select getdate() as serverDate").First();
        }


        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<C_BBdbR_CntlPntBase> C_BBdbR_CntlPntBase { get; set; }
        public virtual DbSet<C_BWuE_CntlLogicDoc> C_BWuE_CntlLogicDoc { get; set; }
        public virtual DbSet<C_BWuE_CntlLogicPro> C_BWuE_CntlLogicPro { get; set; }
        public virtual DbSet<C_Calendar> C_Calendar { get; set; }
        public virtual DbSet<C_CheckProcessing> C_CheckProcessing { get; set; }
        public virtual DbSet<C_CheckProcessingDocument> C_CheckProcessingDocument { get; set; }
        public virtual DbSet<C_CheckTask> C_CheckTask { get; set; }
        public virtual DbSet<C_ClassRankInformation> C_ClassRankInformation { get; set; }
        public virtual DbSet<C_CommingMaterial> C_CommingMaterial { get; set; }
        public virtual DbSet<C_CommingMaterialDetail> C_CommingMaterialDetail { get; set; }
        public virtual DbSet<C_CompanyBaseInformation> C_CompanyBaseInformation { get; set; }
        public virtual DbSet<C_DeliveryDetail> C_DeliveryDetail { get; set; }
        public virtual DbSet<C_DeliveryTask> C_DeliveryTask { get; set; }
        public virtual DbSet<C_EquipmentAlarmDocument> C_EquipmentAlarmDocument { get; set; }
        public virtual DbSet<C_EquipmentAlarmInfomation> C_EquipmentAlarmInfomation { get; set; }
        public virtual DbSet<C_EquipmentAlarmProcessing> C_EquipmentAlarmProcessing { get; set; }
        public virtual DbSet<C_EquipmentGroupBase> C_EquipmentGroupBase { get; set; }
        public virtual DbSet<C_EquipmentInfomation> C_EquipmentInfomation { get; set; }
        public virtual DbSet<C_EquipmentStateDocument> C_EquipmentStateDocument { get; set; }
        public virtual DbSet<C_EquipmentStateProcessing> C_EquipmentStateProcessing { get; set; }
        public virtual DbSet<C_FactoryBaseInformation> C_FactoryBaseInformation { get; set; }
        public virtual DbSet<C_FileFloderInformation> C_FileFloderInformation { get; set; }
        public virtual DbSet<C_FileInformation> C_FileInformation { get; set; }
        public virtual DbSet<C_InfomationPushBase> C_InfomationPushBase { get; set; }
        public virtual DbSet<C_InfomationPushDocument> C_InfomationPushDocument { get; set; }
        public virtual DbSet<C_InfomationPushProcessing> C_InfomationPushProcessing { get; set; }
        public virtual DbSet<C_InfomationPushStaffConfig> C_InfomationPushStaffConfig { get; set; }
        public virtual DbSet<C_KitDocument> C_KitDocument { get; set; }
        public virtual DbSet<C_KitProcessing> C_KitProcessing { get; set; }
        public virtual DbSet<C_LoginInDocument> C_LoginInDocument { get; set; }
        public virtual DbSet<C_LoginInProcessing> C_LoginInProcessing { get; set; }
        public virtual DbSet<C_ProcedureFirstDocument> C_ProcedureFirstDocument { get; set; }
        public virtual DbSet<C_ProcedureFirstRecord> C_ProcedureFirstRecord { get; set; }
        public virtual DbSet<C_ProductDocument> C_ProductDocument { get; set; }
        public virtual DbSet<C_ProductProcessing> C_ProductProcessing { get; set; }
        public virtual DbSet<C_ProductProcessingDocument> C_ProductProcessingDocument { get; set; }
        public virtual DbSet<C_ProductQualityData> C_ProductQualityData { get; set; }
        public virtual DbSet<C_ReformDocument> C_ReformDocument { get; set; }
        public virtual DbSet<C_ShiftBaseInformation> C_ShiftBaseInformation { get; set; }
        public virtual DbSet<C_ShiftTeamConfig> C_ShiftTeamConfig { get; set; }
        public virtual DbSet<C_StaffBaseInformation> C_StaffBaseInformation { get; set; }
        public virtual DbSet<C_SubmitWorktimeInfomation> C_SubmitWorktimeInfomation { get; set; }
        public virtual DbSet<C_TeamBaseInformation> C_TeamBaseInformation { get; set; }
        public virtual DbSet<C_TeamStaffConfig> C_TeamStaffConfig { get; set; }
        public virtual DbSet<C_TurnoverWarehouseDocument> C_TurnoverWarehouseDocument { get; set; }
        public virtual DbSet<C_TurnoverWarehouseProcessing> C_TurnoverWarehouseProcessing { get; set; }
        public virtual DbSet<C_WorkshopBaseInformation> C_WorkshopBaseInformation { get; set; }
        public virtual DbSet<A_CutterDemand> A_CutterDemand { get; set; }
        public virtual DbSet<A_KitBase> A_KitBase { get; set; }
        public virtual DbSet<A_MaterialProgramDemand> A_MaterialProgramDemand { get; set; }
        public virtual DbSet<A_OrderBase> A_OrderBase { get; set; }
        public virtual DbSet<A_PlanProductInfomation> A_PlanProductInfomation { get; set; }
        public virtual DbSet<A_ProcedureBase> A_ProcedureBase { get; set; }
        public virtual DbSet<A_ProcedureCutterConfig> A_ProcedureCutterConfig { get; set; }
        public virtual DbSet<A_ProcedureEquipmentConfig> A_ProcedureEquipmentConfig { get; set; }
        public virtual DbSet<A_ProcedureSelfCheckingConfig> A_ProcedureSelfCheckingConfig { get; set; }
        public virtual DbSet<A_ProcedureStaffSkillConfig> A_ProcedureStaffSkillConfig { get; set; }
        public virtual DbSet<A_ProcessModelBase> A_ProcessModelBase { get; set; }
        public virtual DbSet<A_ProcessProcedureBase> A_ProcessProcedureBase { get; set; }
        public virtual DbSet<A_ProductBase> A_ProductBase { get; set; }
        public virtual DbSet<A_ProductProcedureBase> A_ProductProcedureBase { get; set; }
        public virtual DbSet<A_ProjectInfomation> A_ProjectInfomation { get; set; }
        public virtual DbSet<A_ProjectPlanInfomation> A_ProjectPlanInfomation { get; set; }
        public virtual DbSet<A_ProjectProcessModel> A_ProjectProcessModel { get; set; }
        public virtual DbSet<A_WorkerTaskConfig> A_WorkerTaskConfig { get; set; }
        public virtual DbSet<APS_ProcedureTask> APS_ProcedureTask { get; set; }
        public virtual DbSet<APS_ProcedureTaskDetail> APS_ProcedureTaskDetail { get; set; }
        public virtual DbSet<APS_ResLineTime> APS_ResLineTime { get; set; }
        public virtual DbSet<Base_BackupJob> Base_BackupJob { get; set; }
        public virtual DbSet<Base_Button> Base_Button { get; set; }
        public virtual DbSet<Base_ButtonPermission> Base_ButtonPermission { get; set; }
        public virtual DbSet<Base_CodeRule> Base_CodeRule { get; set; }
        public virtual DbSet<Base_CodeRuleDetail> Base_CodeRuleDetail { get; set; }
        public virtual DbSet<Base_CodeRuleSerious> Base_CodeRuleSerious { get; set; }
        public virtual DbSet<Base_Company> Base_Company { get; set; }
        public virtual DbSet<Base_DataDictionary> Base_DataDictionary { get; set; }
        public virtual DbSet<Base_DataDictionaryDetail> Base_DataDictionaryDetail { get; set; }
        public virtual DbSet<Base_DataScopePermission> Base_DataScopePermission { get; set; }
        public virtual DbSet<Base_Department> Base_Department { get; set; }
        public virtual DbSet<Base_Email> Base_Email { get; set; }
        public virtual DbSet<Base_EmailAccessory> Base_EmailAccessory { get; set; }
        public virtual DbSet<Base_EmailAddressee> Base_EmailAddressee { get; set; }
        public virtual DbSet<Base_EmailCategory> Base_EmailCategory { get; set; }
        public virtual DbSet<Base_Employee> Base_Employee { get; set; }
        public virtual DbSet<Base_ExcelImport> Base_ExcelImport { get; set; }
        public virtual DbSet<Base_ExcelImportDetail> Base_ExcelImportDetail { get; set; }
        public virtual DbSet<Base_FormAttribute> Base_FormAttribute { get; set; }
        public virtual DbSet<Base_FormAttributeValue> Base_FormAttributeValue { get; set; }
        public virtual DbSet<Base_GroupUser> Base_GroupUser { get; set; }
        public virtual DbSet<Base_InterfaceManage> Base_InterfaceManage { get; set; }
        public virtual DbSet<Base_InterfaceManageParameter> Base_InterfaceManageParameter { get; set; }
        public virtual DbSet<Base_Language> Base_Language { get; set; }
        public virtual DbSet<Base_Module> Base_Module { get; set; }
        public virtual DbSet<Base_ModulePermission> Base_ModulePermission { get; set; }
        public virtual DbSet<Base_NetworkFile> Base_NetworkFile { get; set; }
        public virtual DbSet<Base_NetworkFolder> Base_NetworkFolder { get; set; }
        public virtual DbSet<Base_ObjectUserRelation> Base_ObjectUserRelation { get; set; }
        public virtual DbSet<Base_PhoneNote> Base_PhoneNote { get; set; }
        public virtual DbSet<Base_Post> Base_Post { get; set; }
        public virtual DbSet<Base_ProvinceCity> Base_ProvinceCity { get; set; }
        public virtual DbSet<Base_QueryRecord> Base_QueryRecord { get; set; }
        public virtual DbSet<Base_Roles> Base_Roles { get; set; }
        public virtual DbSet<Base_Shortcuts> Base_Shortcuts { get; set; }
        public virtual DbSet<Base_Supplies> Base_Supplies { get; set; }
        public virtual DbSet<Base_SysLog> Base_SysLog { get; set; }
        public virtual DbSet<Base_SysLogDetail> Base_SysLogDetail { get; set; }
        public virtual DbSet<Base_User> Base_User { get; set; }
        public virtual DbSet<Base_View> Base_View { get; set; }
        public virtual DbSet<Base_ViewPermission> Base_ViewPermission { get; set; }
        public virtual DbSet<Base_ViewWhere> Base_ViewWhere { get; set; }
        public virtual DbSet<Base_ViewWherePermission> Base_ViewWherePermission { get; set; }
        public virtual DbSet<D_DEVICE_STATUS> D_DEVICE_STATUS { get; set; }
        public virtual DbSet<DataCollect> DataCollect { get; set; }
        public virtual DbSet<DefectiveProductProcessing> DefectiveProductProcessing { get; set; }
        public virtual DbSet<P_DEVICE_ALARM> P_DEVICE_ALARM { get; set; }
        public virtual DbSet<P_DEVICE_STATUS> P_DEVICE_STATUS { get; set; }
        public virtual DbSet<PettyCash> PettyCash { get; set; }
        public virtual DbSet<POOrder> POOrder { get; set; }
        public virtual DbSet<POOrderEntry> POOrderEntry { get; set; }
        public virtual DbSet<WF_FlowCCRole> WF_FlowCCRole { get; set; }
        public virtual DbSet<WF_FlowLine> WF_FlowLine { get; set; }
        public virtual DbSet<WF_FlowNodeRole> WF_FlowNodeRole { get; set; }
        public virtual DbSet<WF_FrmAttr> WF_FrmAttr { get; set; }
        public virtual DbSet<WF_FrmDetail> WF_FrmDetail { get; set; }
        public virtual DbSet<WF_FrmMain> WF_FrmMain { get; set; }
        public virtual DbSet<WF_FrmNodeRelation> WF_FrmNodeRelation { get; set; }
        public virtual DbSet<WF_Instance> WF_Instance { get; set; }
        public virtual DbSet<WF_NodeButtonRelation> WF_NodeButtonRelation { get; set; }
        public virtual DbSet<RS_ORGE_STRU> RS_ORGE_STRU { get; set; }
        public virtual DbSet<WF_FlowMain> WF_FlowMain { get; set; }
        public virtual DbSet<WF_Task> WF_Task { get; set; }
        public virtual DbSet<VW_LOT_BIRTHCODE> VW_LOT_BIRTHCODE { get; set; }
        public virtual DbSet<VW_LOT_BIRTHCODE_ASS> VW_LOT_BIRTHCODE_ASS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C_EquipmentGroupBase>()
                .Property(e => e.EquipmentGroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentGroupBase>()
                .Property(e => e.EquipmentGroupName)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentGroupBase>()
                .Property(e => e.GroupDescription)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentGroupBase>()
                .Property(e => e.EquipmentModel)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentGroupBase>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentGroupBase>()
                .Property(e => e.Reserve1)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentGroupBase>()
                .Property(e => e.Reserve2)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentGroupBase>()
                .Property(e => e.Reserve3)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentInfomation>()
                .Property(e => e.EquipmentCode)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentInfomation>()
                .Property(e => e.EquipmentGroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentInfomation>()
                .Property(e => e.EquipmentName)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentInfomation>()
                .Property(e => e.EquipmentCategory)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentInfomation>()
                .Property(e => e.EquipmentType)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentInfomation>()
                .Property(e => e.EquipmentModel)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentInfomation>()
                .Property(e => e.EquipmentMaker)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentInfomation>()
                .Property(e => e.EquipmentLife)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentInfomation>()
                .Property(e => e.MaxIdleTime)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_EquipmentInfomation>()
                .Property(e => e.TimeUnit)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentInfomation>()
                .Property(e => e.EquipmentDescription)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentInfomation>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentInfomation>()
                .Property(e => e.Reserve1)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentInfomation>()
                .Property(e => e.Reserve2)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentInfomation>()
                .Property(e => e.Reserve3)
                .IsUnicode(false);

            modelBuilder.Entity<C_EquipmentStateDocument>()
                .Property(e => e.ContinueTime)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_EquipmentStateProcessing>()
                .Property(e => e.ContinueTime)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_FactoryBaseInformation>()
                .Property(e => e.FactoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<C_FactoryBaseInformation>()
                .Property(e => e.FactoryName)
                .IsUnicode(false);

            modelBuilder.Entity<C_FactoryBaseInformation>()
                .Property(e => e.FactoryDescription)
                .IsUnicode(false);

            modelBuilder.Entity<C_FactoryBaseInformation>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<C_FactoryBaseInformation>()
                .Property(e => e.Reserve1)
                .IsUnicode(false);

            modelBuilder.Entity<C_FactoryBaseInformation>()
                .Property(e => e.Reserve2)
                .IsUnicode(false);

            modelBuilder.Entity<C_FactoryBaseInformation>()
                .Property(e => e.Reserve3)
                .IsUnicode(false);

            modelBuilder.Entity<C_FileInformation>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<C_InfomationPushBase>()
                .Property(e => e.IntervalTime)
                .HasPrecision(18, 6);

            modelBuilder.Entity<C_ProcedureFirstDocument>()
                .Property(e => e.PlanCode)
                .IsUnicode(false);

            modelBuilder.Entity<C_ProductQualityData>()
                .Property(e => e.UpperLimit)
                .HasPrecision(18, 6);

            modelBuilder.Entity<C_ProductQualityData>()
                .Property(e => e.LowerLimit)
                .HasPrecision(18, 6);

            modelBuilder.Entity<C_ProductQualityData>()
                .Property(e => e.StandardValue)
                .HasPrecision(18, 6);

            modelBuilder.Entity<C_ProductQualityData>()
                .Property(e => e.CollectValue)
                .HasPrecision(18, 6);

            modelBuilder.Entity<C_SubmitWorktimeInfomation>()
                .Property(e => e.SubmitWorktime)
                .HasPrecision(18, 6);

            modelBuilder.Entity<C_SubmitWorktimeInfomation>()
                .Property(e => e.ActualWorktime)
                .HasPrecision(18, 6);

            modelBuilder.Entity<C_WorkshopBaseInformation>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<A_KitBase>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<A_PlanProductInfomation>()
                .Property(e => e.Price)
                .HasPrecision(18, 6);

            modelBuilder.Entity<A_ProcedureBase>()
                .Property(e => e.CheckTime)
                .HasPrecision(18, 6);

            modelBuilder.Entity<A_ProcedureCutterConfig>()
                .Property(e => e.LeadTime)
                .HasPrecision(18, 6);

            modelBuilder.Entity<A_ProcedureSelfCheckingConfig>()
                .Property(e => e.UpperLimit)
                .HasPrecision(18, 6);

            modelBuilder.Entity<A_ProcedureSelfCheckingConfig>()
                .Property(e => e.LowerLimit)
                .HasPrecision(18, 6);

            modelBuilder.Entity<A_ProcedureSelfCheckingConfig>()
                .Property(e => e.StandardValue)
                .HasPrecision(18, 6);

            modelBuilder.Entity<A_ProductBase>()
                .Property(e => e.StandardCost)
                .HasPrecision(18, 6);

            modelBuilder.Entity<A_ProductProcedureBase>()
                .Property(e => e.CheckTime)
                .HasPrecision(18, 6);

            modelBuilder.Entity<A_ProjectInfomation>()
                .Property(e => e.Price)
                .HasPrecision(18, 6);

            modelBuilder.Entity<APS_ProcedureTask>()
                .Property(e => e.ProgressPercent)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.BackupId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.ServerName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.DbName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.JobName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.Mode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.StartTime)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.FilePath)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.Enabled)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.ButtonId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.JsEvent)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.ActionEvent)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.ButtonPermissionId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.ModuleButtonId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.CodeRuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.CodeRuleDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.CodeRuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.Consted)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.FormatStr)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.FType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.CodeSeriousId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.CodeRuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.LastUpdateDate)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Nature)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Manager)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.ProvinceId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.CityId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.CountyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.County)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.AccountInfo)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Postalcode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Web)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.DataDictionaryId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.DataDictionaryDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.DataDictionaryId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.DataScopePermissionId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.ResourceId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.Condition)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.ConditionJson)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.ScopeType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Nature)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Manager)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.Theme)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.ThemeColour)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.Addresser)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .HasMany(e => e.Base_EmailAccessory)
                .WithOptional(e => e.Base_Email)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Base_Email>()
                .HasMany(e => e.Base_EmailAddressee)
                .WithOptional(e => e.Base_Email)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Base_EmailAccessory>()
                .Property(e => e.EmailAccessoryId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAccessory>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAccessory>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAccessory>()
                .Property(e => e.FilePath)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAccessory>()
                .Property(e => e.FileSize)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAccessory>()
                .Property(e => e.FileType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAddressee>()
                .Property(e => e.EmailAddresseeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAddressee>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAddressee>()
                .Property(e => e.AddresseeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAddressee>()
                .Property(e => e.AddresseeName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.EmailCategoryId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.EmployeeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Photograph)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.IDCard)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.BankCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.OfficeCornet)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.OfficePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.OfficeZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.OfficeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.OfficeFax)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Education)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.School)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Major)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Degree)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.HomeZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.HomeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.HomeFax)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.NativePlace)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Party)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Nation)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Nationality)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Duty)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.WorkingProperty)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Competency)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.EmergencyContact)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.DimissionCause)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.DimissionWhither)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ImportId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ImportName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ImportTable)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ImportTableName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ImportFileName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.ImportDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.ImportId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.ColumnName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.ForeignTable)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.BackField)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.CompareField)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.AttachCondition)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.FieldRemark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.FormAttributeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.PropertyName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ControlId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ControlType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ControlStyle)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ControlValidator)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.DefaultVlaue)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.AttributesProperty)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.DataSource)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ControlColspan)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttributeValue>()
                .Property(e => e.AttributeValueId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttributeValue>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttributeValue>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttributeValue>()
                .Property(e => e.ObjectParameterJson)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.GroupUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.InterfaceId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.Constraints)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .HasMany(e => e.Base_InterfaceManageParameter)
                .WithOptional(e => e.Base_InterfaceManage)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Base_InterfaceManageParameter>()
                .Property(e => e.InterfaceParameterId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManageParameter>()
                .Property(e => e.InterfaceId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManageParameter>()
                .Property(e => e.Field)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManageParameter>()
                .Property(e => e.FieldMemo)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManageParameter>()
                .Property(e => e.FieldType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.LanguageId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.BusinessCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.BusinessName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.FullValue)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.LanguageType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Target)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModulePermission>()
                .Property(e => e.ModulePermissionId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModulePermission>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModulePermission>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModulePermission>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModulePermission>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModulePermission>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.NetworkFileId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.FolderId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.FilePath)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.FileSize)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.FileExtensions)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.FileType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.SharingFolderId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.FolderId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.FolderName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.SharingFolderId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ObjectUserRelation>()
                .Property(e => e.ObjectUserRelationId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ObjectUserRelation>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ObjectUserRelation>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ObjectUserRelation>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ObjectUserRelation>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ObjectUserRelation>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.PhoneNoteId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.PhonenNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.SendContent)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.SendStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.DeviceName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.PostId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.RoleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.ProvinceCityId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.QueryRecordId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.ConditionJson)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.RoleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Shortcuts>()
                .Property(e => e.ShortcutsId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Shortcuts>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Shortcuts>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.AccountsMethod)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.LeadingOfficialId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.SysLogId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.LogType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.IPAddressName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .HasMany(e => e.Base_SysLogDetail)
                .WithOptional(e => e.Base_SysLog)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Base_SysLogDetail>()
                .Property(e => e.SysLogDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLogDetail>()
                .Property(e => e.SysLogId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLogDetail>()
                .Property(e => e.PropertyName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLogDetail>()
                .Property(e => e.PropertyField)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLogDetail>()
                .Property(e => e.NewValue)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLogDetail>()
                .Property(e => e.OldValue)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Secretkey)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Spell)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.OICQ)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.AuditStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.AuditUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.AuditUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.ViewId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.ShowName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.TextAlign)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.CustomSwitch)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.ViewPermissionId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.ViewId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ViewWhereId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ControlType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ControlDefault)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ControlSource)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ShowName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ControlCustom)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.ViewWherePermissionId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.ViewId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.ViewWhereDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<DataCollect>()
                .Property(e => e.WorkCenterCode)
                .IsUnicode(false);

            modelBuilder.Entity<DataCollect>()
                .Property(e => e.SerialCode)
                .IsUnicode(false);

            modelBuilder.Entity<DataCollect>()
                .Property(e => e.AddressName)
                .IsUnicode(false);

            modelBuilder.Entity<DataCollect>()
                .Property(e => e.AddressValue)
                .IsUnicode(false);

            modelBuilder.Entity<DataCollect>()
                .Property(e => e.ErrorMsg)
                .IsUnicode(false);

            modelBuilder.Entity<P_DEVICE_ALARM>()
                .Property(e => e.RECORD_ID)
                .IsUnicode(false);

            modelBuilder.Entity<P_DEVICE_ALARM>()
                .Property(e => e.DEVICE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<P_DEVICE_ALARM>()
                .Property(e => e.DEVICE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<P_DEVICE_ALARM>()
                .Property(e => e.DEVICE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<P_DEVICE_ALARM>()
                .Property(e => e.ADDRESS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<P_DEVICE_ALARM>()
                .Property(e => e.ALARM_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<P_DEVICE_ALARM>()
                .Property(e => e.ALARM_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<P_DEVICE_ALARM>()
                .Property(e => e.ALARM_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<P_DEVICE_ALARM>()
                .Property(e => e.ALARM_REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PettyCash>()
                .Property(e => e.PettyCashId)
                .IsUnicode(false);

            modelBuilder.Entity<PettyCash>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<PettyCash>()
                .Property(e => e.Keeper)
                .IsUnicode(false);

            modelBuilder.Entity<PettyCash>()
                .Property(e => e.KeepType)
                .IsUnicode(false);

            modelBuilder.Entity<PettyCash>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<PettyCash>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<PettyCash>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<PettyCash>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<PettyCash>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.POOrderId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.BillNo)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.Method)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.Clearing)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.Currency)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.FetchAdd)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.SalesmanId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.Salesman)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.CreateDepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.CreateDepartmentName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.ModifyDepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.ModifyDepartmentName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.AuditStatus)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.AuditStatusName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.POOrderEntryId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.POOrderId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.ItemId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.ItemModel)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.UnitId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowCCRole>()
                .Property(e => e.FlowCCRoleId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowCCRole>()
                .Property(e => e.FlowMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowCCRole>()
                .Property(e => e.ControlName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowCCRole>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowCCRole>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowCCRole>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowCCRole>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowLine>()
                .Property(e => e.FlowLineId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowLine>()
                .Property(e => e.FlowMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowLine>()
                .Property(e => e.FlowLineCode)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowLine>()
                .Property(e => e.SourceNodeId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowLine>()
                .Property(e => e.GoNodeId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowLine>()
                .Property(e => e.ConditionString)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowLine>()
                .Property(e => e.ConditionJson)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowLine>()
                .Property(e => e.ConditionValueJson)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowLine>()
                .Property(e => e.CreateInclude)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowLine>()
                .Property(e => e.CreateWithout)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowLine>()
                .Property(e => e.ExcuteInclude)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowLine>()
                .Property(e => e.ExcuteWithout)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowLine>()
                .Property(e => e.UserMethod)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowLine>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowLine>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowLine>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowLine>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowLine>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowNodeRole>()
                .Property(e => e.FlowNodeRoleId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowNodeRole>()
                .Property(e => e.FlowNodeId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowNodeRole>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowNodeRole>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowNodeRole>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowNodeRole>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowNodeRole>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmAttr>()
                .Property(e => e.FrmAttrId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmAttr>()
                .Property(e => e.FrmMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmAttr>()
                .Property(e => e.ControlName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmAttr>()
                .Property(e => e.BindFeild)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmAttr>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmAttr>()
                .Property(e => e.DefVal)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmAttr>()
                .Property(e => e.ControlType)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmAttr>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmAttr>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmAttr>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmAttr>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmDetail>()
                .Property(e => e.FrmDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmDetail>()
                .Property(e => e.FrmAttrId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmDetail>()
                .Property(e => e.ControlName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmDetail>()
                .Property(e => e.BindFeild)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmDetail>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmDetail>()
                .Property(e => e.DefVal)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmDetail>()
                .Property(e => e.ControlType)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.FrmMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.FrmCode)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.FrmVersion)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.FrmTable)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.PrimaryKey)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.Heading)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.FrmHtml)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.FrmEventJson)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.FrmDept)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.FrmURL)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmNodeRelation>()
                .Property(e => e.FrmNodeRelationId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmNodeRelation>()
                .Property(e => e.FlowNodeId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmNodeRelation>()
                .Property(e => e.FrmTable)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmNodeRelation>()
                .Property(e => e.FrmField)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmNodeRelation>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmNodeRelation>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmNodeRelation>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmNodeRelation>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Instance>()
                .Property(e => e.InstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Instance>()
                .Property(e => e.FlowMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Instance>()
                .Property(e => e.FrmMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Instance>()
                .Property(e => e.TaskId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Instance>()
                .Property(e => e.FirstStepId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Instance>()
                .Property(e => e.StartUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Instance>()
                .Property(e => e.CurrentStepId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Instance>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Instance>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Instance>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Instance>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Instance>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Instance>()
                .Property(e => e.FlowTitle)
                .IsUnicode(false);

            modelBuilder.Entity<WF_NodeButtonRelation>()
                .Property(e => e.NodeButtonRelationId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_NodeButtonRelation>()
                .Property(e => e.FlowNodeId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_NodeButtonRelation>()
                .Property(e => e.ButtonId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_NodeButtonRelation>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_NodeButtonRelation>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_NodeButtonRelation>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_NodeButtonRelation>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<RS_ORGE_STRU>()
                .Property(e => e.RECORD_ID)
                .IsUnicode(false);

            modelBuilder.Entity<RS_ORGE_STRU>()
                .Property(e => e.PARENT_ORGE)
                .IsUnicode(false);

            modelBuilder.Entity<RS_ORGE_STRU>()
                .Property(e => e.CHILD_ORGE)
                .IsUnicode(false);

            modelBuilder.Entity<RS_ORGE_STRU>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<RS_ORGE_STRU>()
                .Property(e => e.ENABLED)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowMain>()
                .Property(e => e.FlowMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowMain>()
                .Property(e => e.FlowCode)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowMain>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowMain>()
                .Property(e => e.RunWay)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowMain>()
                .Property(e => e.FlowJson)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowMain>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowMain>()
                .Property(e => e.LinkUrl)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowMain>()
                .Property(e => e.FrmType)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowMain>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowMain>()
                .Property(e => e.RunSQL)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowMain>()
                .Property(e => e.CCRole)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowMain>()
                .Property(e => e.ValidDays)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WF_FlowMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FlowMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Task>()
                .Property(e => e.FlowTaskId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Task>()
                .Property(e => e.InstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Task>()
                .Property(e => e.FlowMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Task>()
                .Property(e => e.FrmMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Task>()
                .Property(e => e.TaskId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Task>()
                .Property(e => e.StepId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Task>()
                .Property(e => e.ExcuteObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Task>()
                .Property(e => e.ExcuteObjectName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Task>()
                .Property(e => e.BeforeStepId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Task>()
                .Property(e => e.LastStepId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Task>()
                .Property(e => e.LastStepUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Task>()
                .Property(e => e.ExcuteUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Task>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Task>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Task>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Task>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Task>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_Task>()
                .Property(e => e.FlowTitle)
                .IsUnicode(false);

            modelBuilder.Entity<VW_LOT_BIRTHCODE>()
                .Property(e => e.产品出生证)
                .IsUnicode(false);

            modelBuilder.Entity<VW_LOT_BIRTHCODE>()
                .Property(e => e.产品名称)
                .IsUnicode(false);

            modelBuilder.Entity<VW_LOT_BIRTHCODE>()
                .Property(e => e.产品编号)
                .IsUnicode(false);

            modelBuilder.Entity<VW_LOT_BIRTHCODE>()
                .Property(e => e.订单编号)
                .IsUnicode(false);

            modelBuilder.Entity<VW_LOT_BIRTHCODE>()
                .Property(e => e.订单名称)
                .IsUnicode(false);

            modelBuilder.Entity<VW_LOT_BIRTHCODE>()
                .Property(e => e.执行状态)
                .IsUnicode(false);

            modelBuilder.Entity<VW_LOT_BIRTHCODE>()
                .Property(e => e.产品状态)
                .IsUnicode(false);

            modelBuilder.Entity<VW_LOT_BIRTHCODE_ASS>()
                .Property(e => e.产品出生证)
                .IsUnicode(false);

            modelBuilder.Entity<VW_LOT_BIRTHCODE_ASS>()
                .Property(e => e.产品名称)
                .IsUnicode(false);

            modelBuilder.Entity<VW_LOT_BIRTHCODE_ASS>()
                .Property(e => e.产品编号)
                .IsUnicode(false);

            modelBuilder.Entity<VW_LOT_BIRTHCODE_ASS>()
                .Property(e => e.是否返修)
                .IsUnicode(false);

            modelBuilder.Entity<VW_LOT_BIRTHCODE_ASS>()
                .Property(e => e.返修代码)
                .IsUnicode(false);

            modelBuilder.Entity<VW_LOT_BIRTHCODE_ASS>()
                .Property(e => e.返修原因)
                .IsUnicode(false);

            modelBuilder.Entity<VW_LOT_BIRTHCODE_ASS>()
                .Property(e => e.订单编号)
                .IsUnicode(false);

            modelBuilder.Entity<VW_LOT_BIRTHCODE_ASS>()
                .Property(e => e.订单名称)
                .IsUnicode(false);

            modelBuilder.Entity<VW_LOT_BIRTHCODE_ASS>()
                .Property(e => e.执行状态)
                .IsUnicode(false);

            modelBuilder.Entity<VW_LOT_BIRTHCODE_ASS>()
                .Property(e => e.产品状态)
                .IsUnicode(false);
        }
    }
}
