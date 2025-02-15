﻿using System.IO;
using System.Text;
using Casbin.Adapter.File;
using Casbin.Model;
using Casbin.Persist;

namespace Casbin.UnitTests.Fixtures;

public class TestModelFixture
{
    internal readonly string _abacModelText = ReadTestFile("abac_model.conf");
    internal readonly string _abacWithEvalModelText = ReadTestFile("abac_rule_model.conf");

    internal readonly string _abacWithEvalPolicyText = ReadTestFile("abac_rule_policy.csv");
    internal readonly string _basicModelText = ReadTestFile("basic_model.conf");
    internal readonly string _basicPolicyText = ReadTestFile("basic_policy.csv");
    internal readonly string _basicWithoutResourceModelText = ReadTestFile("basic_without_resources_model.conf");
    internal readonly string _basicWithoutResourcePolicyText = ReadTestFile("basic_without_resources_policy.csv");
    internal readonly string _basicWithoutUserModelText = ReadTestFile("basic_without_users_model.conf");
    internal readonly string _basicWithoutUserPolicyText = ReadTestFile("basic_without_users_policy.csv");
    internal readonly string _basicWithRootModelText = ReadTestFile("basic_with_root_model.conf");
    internal readonly string _ipMatchModelText = ReadTestFile("ipmatch_model.conf");
    internal readonly string _ipMatchPolicyText = ReadTestFile("ipmatch_policy.csv");
    internal readonly string _keyMatch2ModelText = ReadTestFile("keymatch2_model.conf");
    internal readonly string _keyMatch2PolicyText = ReadTestFile("keymatch2_policy.csv");
    internal readonly string _keyMatchCustomModelText = ReadTestFile("keymatch_custom_model.conf");
    internal readonly string _keyMatchModelText = ReadTestFile("keymatch_model.conf");
    internal readonly string _keyMatchPolicyText = ReadTestFile("keymatch_policy.csv");

    // https://github.com/casbin/Casbin.NET/issues/134
    internal readonly string _multipleTypeModelText = ReadTestFile("multiple_type_model.conf");
    internal readonly string _multipleTypePolicyText = ReadTestFile("multiple_type_policy.csv");

    // https://github.com/casbin/Casbin.NET/issues/188
    internal readonly string _priorityExplicitDenyOverrideModelText =
        ReadTestFile("priority_explicit_deny_override_model.conf");

    internal readonly string _priorityExplicitDenyOverridePolicyText =
        ReadTestFile("priority_explicit_deny_override_policy.csv");

    internal readonly string _priorityExplicitModelText = ReadTestFile("priority_explicit_model.conf");
    internal readonly string _priorityExplicitPolicyText = ReadTestFile("priority_explicit_policy.csv");
    internal readonly string _priorityIndeterminatePolicyText = ReadTestFile("priority_indeterminate_policy.csv");
    internal readonly string _priorityModelText = ReadTestFile("priority_model.conf");
    internal readonly string _priorityPolicyText = ReadTestFile("priority_policy.csv");
    internal readonly string _rbacModelText = ReadTestFile("rbac_model.conf");

    internal readonly string _rbacInOperatorModelText = ReadTestFile("rbac_in_operator_model.conf");
    internal readonly string _rbacInOperatorPolicyText = ReadTestFile("rbac_in_operator_policy.csv");

    // https://github.com/casbin/Casbin.NET/issues/106
    internal readonly string _rbacMultipleEvalModelText = ReadTestFile("rbac_multiple_eval_model.conf");
    internal readonly string _rbacMultipleEvalPolicyText = ReadTestFile("rbac_multiple_eval_policy.csv");

    internal readonly string _abacCommentText = ReadTestFile("abac_comment.conf");
    internal readonly string _rbacCommentText = ReadTestFile("rbac_comment.conf");

    // https://github.com/casbin/Casbin.NET/issues/154
    internal readonly string _rbacMultipleModelText = ReadTestFile("rbac_multiple_rolemanager_model.conf");
    internal readonly string _rbacMultiplePolicyText = ReadTestFile("rbac_multiple_rolemanager_policy.csv");
    internal readonly string _rbacPolicyText = ReadTestFile("rbac_policy.csv");
    internal readonly string _rbacWithDenyModelText = ReadTestFile("rbac_with_deny_model.conf");
    internal readonly string _rbacWithDenyPolicyText = ReadTestFile("rbac_with_deny_policy.csv");
    internal readonly string _rbacWithDomainsModelText = ReadTestFile("rbac_with_domains_model.conf");
    internal readonly string _rbacWithDomainsPolicy2Text = ReadTestFile("rbac_with_domains_policy2.csv");
    internal readonly string _rbacWithDomainsPolicyText = ReadTestFile("rbac_with_domains_policy.csv");
    internal readonly string _rbacWithHierarchyPolicyText = ReadTestFile("rbac_with_hierarchy_policy.csv");

    internal readonly string _rbacWithHierarchyWithDomainsPolicyText =
        ReadTestFile("rbac_with_hierarchy_with_domains_policy.csv");

    internal readonly string _rbacWithNotDenyModelText = ReadTestFile("rbac_with_not_deny_model.conf");
    internal readonly string _rbacWithResourceRoleModelText = ReadTestFile("rbac_with_resource_roles_model.conf");

    internal readonly string _rbacWithResourceRolePolicyText = ReadTestFile("rbac_with_resource_roles_policy.csv");
    internal readonly string _subjectPriorityModelText = ReadTestFile("subject_priority_model.conf");
    internal readonly string _subjectPriorityPolicyText = ReadTestFile("subject_priority_policy.csv");

    internal readonly string _subjectPriorityWithDomainModelText =
        ReadTestFile("subject_priority_model_with_domain.conf");

    internal readonly string _subjectPriorityWithDomainPolicyText =
        ReadTestFile("subject_priority_policy_with_domain.csv");

    // https://github.com/casbin/Casbin.NET/issues/229
    internal readonly string _supportCountModelText = ReadTestFile("support_count_model.conf");

    public IModel GetNewAbacModel() => GetNewTestModel(_abacModelText);

    public IModel GetNewAbacWithEvalModel() => GetNewTestModel(_abacWithEvalModelText, _abacWithEvalPolicyText);

    public IModel GetBasicTestModel() => GetNewTestModel(_basicModelText, _basicPolicyText);

    public IModel GetBasicWithoutResourceTestModel() =>
        GetNewTestModel(_basicWithoutResourceModelText, _basicWithoutResourcePolicyText);

    public IModel GetBasicWithoutUserTestModel() =>
        GetNewTestModel(_basicWithoutUserModelText, _basicWithoutUserPolicyText);

    public IModel GetNewKeyMatchTestModel() => GetNewTestModel(_keyMatchModelText, _keyMatchPolicyText);

    public IModel GetNewKeyMatch2TestModel() => GetNewTestModel(_keyMatch2ModelText, _keyMatch2PolicyText);

    public IModel GetNewPriorityTestModel() => GetNewTestModel(_priorityModelText, _priorityPolicyText);

    public IModel GetNewPriorityExplicitTestModel() =>
        GetNewTestModel(_priorityExplicitModelText, _priorityExplicitPolicyText);

    public IModel GetNewPriorityExplicitDenyOverrideModel() => GetNewTestModel(_priorityExplicitDenyOverrideModelText,
        _priorityExplicitDenyOverridePolicyText);

    public IModel GetNewRbacTestModel() => GetNewTestModel(_rbacModelText, _rbacPolicyText);

    public IModel GetNewRbacWithDenyTestModel() => GetNewTestModel(_rbacWithDenyModelText, _rbacWithDenyPolicyText);

    public IModel GetNewRbacWithDomainsTestModel() =>
        GetNewTestModel(_rbacWithDomainsModelText, _rbacWithDomainsPolicyText);

    public IModel GetNewRbacWithResourceRoleTestModel() =>
        GetNewTestModel(_rbacWithResourceRoleModelText, _rbacWithResourceRolePolicyText);

    public IModel GetNewMultipleTypeTestModel() => GetNewTestModel(_multipleTypeModelText, _multipleTypePolicyText);

    public static IModel GetNewTestModel(string modelText) => DefaultModel.CreateFromText(modelText);

    public static IModel GetNewTestModel(string modelText, string policyText) =>
        LoadModelFromMemory(GetNewTestModel(modelText), policyText);

    public static string GetTestFile(string fileName) => Path.Combine("Examples", fileName);

    private static IModel LoadModelFromMemory(IModel model, string policy)
    {
        using MemoryStream ms = new(Encoding.UTF8.GetBytes(policy));
        FileAdapter fileAdapter = new(ms);
        fileAdapter.LoadPolicy(model);
        model.SortPolicy();
        return model;
    }

    private static string ReadTestFile(string fileName) => File.ReadAllText(GetTestFile(fileName));
}
