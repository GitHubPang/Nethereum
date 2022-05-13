using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Nethereum.Optimism.L1StandardBridge.ContractDefinition
{


    public partial class L1StandardBridgeDeployment : L1StandardBridgeDeploymentBase
    {
        public L1StandardBridgeDeployment() : base(BYTECODE) { }
        public L1StandardBridgeDeployment(string byteCode) : base(byteCode) { }
    }

    public class L1StandardBridgeDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405234801561001057600080fd5b50600080546001600160a01b031916905561140b806100306000396000f3fe6080604052600436106100a05760003560e01c80638b4c40b0116100645780638b4c40b0146100eb5780638f601f66146101af57806391c49bf8146101f55780639a2ac6d514610215578063a9f9e67514610228578063b1a1a8821461024857600080fd5b80631532ec34146100f25780633cb747bf14610112578063485cc9551461014f57806358a997f61461016f578063838b25201461018f57600080fd5b366100ed57333b156100cd5760405162461bcd60e51b81526004016100c490610d24565b60405180910390fd5b6100eb333362030d406040518060200160405280600081525061025b565b005b600080fd5b3480156100fe57600080fd5b506100eb61010d366004610dae565b610335565b34801561011e57600080fd5b50600054610132906001600160a01b031681565b6040516001600160a01b0390911681526020015b60405180910390f35b34801561015b57600080fd5b506100eb61016a366004610e21565b610558565b34801561017b57600080fd5b506100eb61018a366004610e73565b6105ee565b34801561019b57600080fd5b506100eb6101aa366004610ef6565b610625565b3480156101bb57600080fd5b506101e76101ca366004610e21565b600260209081526000928352604080842090915290825290205481565b604051908152602001610146565b34801561020157600080fd5b50600154610132906001600160a01b031681565b6100eb610223366004610f8c565b61063e565b34801561023457600080fd5b506100eb610243366004610fef565b610686565b6100eb610256366004611068565b610844565b600063662a633a60e01b600073deaddeaddeaddeaddeaddeaddeaddeaddead00008787348760405160240161029596959493929190611113565b60408051601f198184030181529190526020810180516001600160e01b03166001600160e01b0319909316929092179091526001549091506102e1906001600160a01b031684836108aa565b836001600160a01b0316856001600160a01b03167f35d79ab81f2b2017e19afb5c5571778877782d7a8786f5907f93b0f4702f4f233485604051610326929190611162565b60405180910390a35050505050565b6001546001600160a01b03166103536000546001600160a01b031690565b6001600160a01b0316336001600160a01b0316146103835760405162461bcd60e51b81526004016100c49061117b565b806001600160a01b031661039f6000546001600160a01b031690565b6001600160a01b0316636e296e456040518163ffffffff1660e01b8152600401602060405180830381865afa1580156103dc573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061040091906111c9565b6001600160a01b0316146104265760405162461bcd60e51b81526004016100c4906111e6565b604080516000808252602082019092526001600160a01b0387169086906040516104509190611236565b60006040518083038185875af1925050503d806000811461048d576040519150601f19603f3d011682016040523d82523d6000602084013e610492565b606091505b50509050806105005760405162461bcd60e51b815260206004820152603460248201527f5472616e7366657248656c7065723a3a736166655472616e736665724554483a60448201527308115512081d1c985b9cd9995c8819985a5b195960621b60648201526084016100c4565b856001600160a01b0316876001600160a01b03167f2ac69ee804d9a7a0984249f508dfab7cb2534b465b6ce1580f99a38ba9c5e6318787876040516105479392919061127b565b60405180910390a350505050505050565b6000546001600160a01b0316156105c05760405162461bcd60e51b815260206004820152602660248201527f436f6e74726163742068617320616c7265616479206265656e20696e697469616044820152653634bd32b21760d11b60648201526084016100c4565b600080546001600160a01b039384166001600160a01b03199182161790915560018054929093169116179055565b333b1561060d5760405162461bcd60e51b81526004016100c490610d24565b61061d868633338888888861090c565b505050505050565b610635878733888888888861090c565b50505050505050565b61068033858585858080601f01602080910402602001604051908101604052809392919081815260200183838082843760009201919091525061025b92505050565b50505050565b6001546001600160a01b03166106a46000546001600160a01b031690565b6001600160a01b0316336001600160a01b0316146106d45760405162461bcd60e51b81526004016100c49061117b565b806001600160a01b03166106f06000546001600160a01b031690565b6001600160a01b0316636e296e456040518163ffffffff1660e01b8152600401602060405180830381865afa15801561072d573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061075191906111c9565b6001600160a01b0316146107775760405162461bcd60e51b81526004016100c4906111e6565b6001600160a01b038089166000908152600260209081526040808320938b16835292905220546107a89085906112b4565b6001600160a01b03808a166000818152600260209081526040808320948d16835293905291909120919091556107df908686610a3d565b856001600160a01b0316876001600160a01b0316896001600160a01b03167f3ceee06c1e37648fcbb6ed52e17b3e1f275a1f8c7b22a84b2b84732431e046b38888888860405161083294939291906112cb565b60405180910390a45050505050505050565b333b156108635760405162461bcd60e51b81526004016100c490610d24565b6108a533338585858080601f01602080910402602001604051908101604052809392919081815260200183838082843760009201919091525061025b92505050565b505050565b600054604051633dbb202b60e01b81526001600160a01b0390911690633dbb202b906108de908690859087906004016112fd565b600060405180830381600087803b1580156108f857600080fd5b505af1158015610635573d6000803e3d6000fd5b6109216001600160a01b038916873087610aa0565b600063662a633a60e01b898989898988886040516024016109489796959493929190611337565b60408051601f198184030181529190526020810180516001600160e01b03166001600160e01b031990931692909217909152600154909150610994906001600160a01b031685836108aa565b6001600160a01b03808a166000908152600260209081526040808320938c16835292905220546109c5908690611388565b6001600160a01b03808b1660008181526002602090815260408083208e86168085529252918290209490945551918a1692917f718594027abd4eaed59f95162563e0cc6d0e8d5b86b1c7be8b1b0ac3343d039690610a2a908b908b908a908a906112cb565b60405180910390a4505050505050505050565b6040516001600160a01b0383166024820152604481018290526108a590849063a9059cbb60e01b906064015b60408051601f198184030181529190526020810180516001600160e01b03166001600160e01b031990931692909217909152610ad8565b6040516001600160a01b03808516602483015283166044820152606481018290526106809085906323b872dd60e01b90608401610a69565b6000610b2d826040518060400160405280602081526020017f5361666545524332303a206c6f772d6c6576656c2063616c6c206661696c6564815250856001600160a01b0316610baa9092919063ffffffff16565b8051909150156108a55780806020019051810190610b4b91906113a0565b6108a55760405162461bcd60e51b815260206004820152602a60248201527f5361666545524332303a204552433230206f7065726174696f6e20646964206e6044820152691bdd081cdd58d8d9595960b21b60648201526084016100c4565b6060610bb98484600085610bc3565b90505b9392505050565b606082471015610c245760405162461bcd60e51b815260206004820152602660248201527f416464726573733a20696e73756666696369656e742062616c616e636520666f6044820152651c8818d85b1b60d21b60648201526084016100c4565b843b610c725760405162461bcd60e51b815260206004820152601d60248201527f416464726573733a2063616c6c20746f206e6f6e2d636f6e747261637400000060448201526064016100c4565b600080866001600160a01b03168587604051610c8e9190611236565b60006040518083038185875af1925050503d8060008114610ccb576040519150601f19603f3d011682016040523d82523d6000602084013e610cd0565b606091505b5091509150610ce0828286610ceb565b979650505050505050565b60608315610cfa575081610bbc565b825115610d0a5782518084602001fd5b8160405162461bcd60e51b81526004016100c491906113c2565b6020808252600f908201526e4163636f756e74206e6f7420454f4160881b604082015260600190565b6001600160a01b0381168114610d6257600080fd5b50565b60008083601f840112610d7757600080fd5b50813567ffffffffffffffff811115610d8f57600080fd5b602083019150836020828501011115610da757600080fd5b9250929050565b600080600080600060808688031215610dc657600080fd5b8535610dd181610d4d565b94506020860135610de181610d4d565b935060408601359250606086013567ffffffffffffffff811115610e0457600080fd5b610e1088828901610d65565b969995985093965092949392505050565b60008060408385031215610e3457600080fd5b8235610e3f81610d4d565b91506020830135610e4f81610d4d565b809150509250929050565b803563ffffffff81168114610e6e57600080fd5b919050565b60008060008060008060a08789031215610e8c57600080fd5b8635610e9781610d4d565b95506020870135610ea781610d4d565b945060408701359350610ebc60608801610e5a565b9250608087013567ffffffffffffffff811115610ed857600080fd5b610ee489828a01610d65565b979a9699509497509295939492505050565b600080600080600080600060c0888a031215610f1157600080fd5b8735610f1c81610d4d565b96506020880135610f2c81610d4d565b95506040880135610f3c81610d4d565b945060608801359350610f5160808901610e5a565b925060a088013567ffffffffffffffff811115610f6d57600080fd5b610f798a828b01610d65565b989b979a50959850939692959293505050565b60008060008060608587031215610fa257600080fd5b8435610fad81610d4d565b9350610fbb60208601610e5a565b9250604085013567ffffffffffffffff811115610fd757600080fd5b610fe387828801610d65565b95989497509550505050565b600080600080600080600060c0888a03121561100a57600080fd5b873561101581610d4d565b9650602088013561102581610d4d565b9550604088013561103581610d4d565b9450606088013561104581610d4d565b93506080880135925060a088013567ffffffffffffffff811115610f6d57600080fd5b60008060006040848603121561107d57600080fd5b61108684610e5a565b9250602084013567ffffffffffffffff8111156110a257600080fd5b6110ae86828701610d65565b9497909650939450505050565b60005b838110156110d65781810151838201526020016110be565b838111156106805750506000910152565b600081518084526110ff8160208601602086016110bb565b601f01601f19169290920160200192915050565b6001600160a01b03878116825286811660208301528581166040830152841660608201526080810183905260c060a08201819052600090611156908301846110e7565b98975050505050505050565b828152604060208201526000610bb960408301846110e7565b6020808252602e908201527f4f564d5f58434841494e3a206d657373656e67657220636f6e7472616374207560408201526d1b985d5d1a195b9d1a58d85d195960921b606082015260800190565b6000602082840312156111db57600080fd5b8151610bbc81610d4d565b60208082526030908201527f4f564d5f58434841494e3a2077726f6e672073656e646572206f662063726f7360408201526f732d646f6d61696e206d65737361676560801b606082015260800190565b600082516112488184602087016110bb565b9190910192915050565b81835281816020850137506000828201602090810191909152601f909101601f19169091010190565b838152604060208201526000611295604083018486611252565b95945050505050565b634e487b7160e01b600052601160045260246000fd5b6000828210156112c6576112c661129e565b500390565b60018060a01b03851681528360208201526060604082015260006112f3606083018486611252565b9695505050505050565b6001600160a01b0384168152606060208201819052600090611321908301856110e7565b905063ffffffff83166040830152949350505050565b6001600160a01b03888116825287811660208301528681166040830152851660608201526080810184905260c060a0820181905260009061137b9083018486611252565b9998505050505050505050565b6000821982111561139b5761139b61129e565b500190565b6000602082840312156113b257600080fd5b81518015158114610bbc57600080fd5b602081526000610bbc60208301846110e756fea26469706673582212203bd8912d841b79205db78a936dd1623d38b4f18780cdf8d4bf05e39c9e212fab64736f6c634300080b0033";
        public L1StandardBridgeDeploymentBase() : base(BYTECODE) { }
        public L1StandardBridgeDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class DepositERC20Function : DepositERC20FunctionBase { }

    [Function("depositERC20")]
    public class DepositERC20FunctionBase : FunctionMessage
    {
        [Parameter("address", "_l1Token", 1)]
        public virtual string L1Token { get; set; }
        [Parameter("address", "_l2Token", 2)]
        public virtual string L2Token { get; set; }
        [Parameter("uint256", "_amount", 3)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("uint32", "_l2Gas", 4)]
        public virtual uint L2Gas { get; set; }
        [Parameter("bytes", "_data", 5)]
        public virtual byte[] Data { get; set; }
    }

    public partial class DepositERC20ToFunction : DepositERC20ToFunctionBase { }

    [Function("depositERC20To")]
    public class DepositERC20ToFunctionBase : FunctionMessage
    {
        [Parameter("address", "_l1Token", 1)]
        public virtual string L1Token { get; set; }
        [Parameter("address", "_l2Token", 2)]
        public virtual string L2Token { get; set; }
        [Parameter("address", "_to", 3)]
        public virtual string To { get; set; }
        [Parameter("uint256", "_amount", 4)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("uint32", "_l2Gas", 5)]
        public virtual uint L2Gas { get; set; }
        [Parameter("bytes", "_data", 6)]
        public virtual byte[] Data { get; set; }
    }

    public partial class DepositETHFunction : DepositETHFunctionBase { }

    [Function("depositETH")]
    public class DepositETHFunctionBase : FunctionMessage
    {
        [Parameter("uint32", "_l2Gas", 1)]
        public virtual uint L2Gas { get; set; }
        [Parameter("bytes", "_data", 2)]
        public virtual byte[] Data { get; set; }
    }

    public partial class DepositETHToFunction : DepositETHToFunctionBase { }

    [Function("depositETHTo")]
    public class DepositETHToFunctionBase : FunctionMessage
    {
        [Parameter("address", "_to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint32", "_l2Gas", 2)]
        public virtual uint L2Gas { get; set; }
        [Parameter("bytes", "_data", 3)]
        public virtual byte[] Data { get; set; }
    }

    public partial class DepositsFunction : DepositsFunctionBase { }

    [Function("deposits", "uint256")]
    public class DepositsFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
    }

    public partial class DonateETHFunction : DonateETHFunctionBase { }

    [Function("donateETH")]
    public class DonateETHFunctionBase : FunctionMessage
    {

    }

    public partial class FinalizeERC20WithdrawalFunction : FinalizeERC20WithdrawalFunctionBase { }

    [Function("finalizeERC20Withdrawal")]
    public class FinalizeERC20WithdrawalFunctionBase : FunctionMessage
    {
        [Parameter("address", "_l1Token", 1)]
        public virtual string L1Token { get; set; }
        [Parameter("address", "_l2Token", 2)]
        public virtual string L2Token { get; set; }
        [Parameter("address", "_from", 3)]
        public virtual string From { get; set; }
        [Parameter("address", "_to", 4)]
        public virtual string To { get; set; }
        [Parameter("uint256", "_amount", 5)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("bytes", "_data", 6)]
        public virtual byte[] Data { get; set; }
    }

    public partial class FinalizeETHWithdrawalFunction : FinalizeETHWithdrawalFunctionBase { }

    [Function("finalizeETHWithdrawal")]
    public class FinalizeETHWithdrawalFunctionBase : FunctionMessage
    {
        [Parameter("address", "_from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "_to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "_amount", 3)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("bytes", "_data", 4)]
        public virtual byte[] Data { get; set; }
    }

    public partial class InitializeFunction : InitializeFunctionBase { }

    [Function("initialize")]
    public class InitializeFunctionBase : FunctionMessage
    {
        [Parameter("address", "_l1messenger", 1)]
        public virtual string L1messenger { get; set; }
        [Parameter("address", "_l2TokenBridge", 2)]
        public virtual string L2TokenBridge { get; set; }
    }

    public partial class L2TokenBridgeFunction : L2TokenBridgeFunctionBase { }

    [Function("l2TokenBridge", "address")]
    public class L2TokenBridgeFunctionBase : FunctionMessage
    {

    }

    public partial class MessengerFunction : MessengerFunctionBase { }

    [Function("messenger", "address")]
    public class MessengerFunctionBase : FunctionMessage
    {

    }

    public partial class ERC20DepositInitiatedEventDTO : ERC20DepositInitiatedEventDTOBase { }

    [Event("ERC20DepositInitiated")]
    public class ERC20DepositInitiatedEventDTOBase : IEventDTO
    {
        [Parameter("address", "_l1Token", 1, true)]
        public virtual string L1Token { get; set; }
        [Parameter("address", "_l2Token", 2, true)]
        public virtual string L2Token { get; set; }
        [Parameter("address", "_from", 3, true)]
        public virtual string From { get; set; }
        [Parameter("address", "_to", 4, false)]
        public virtual string To { get; set; }
        [Parameter("uint256", "_amount", 5, false)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("bytes", "_data", 6, false)]
        public virtual byte[] Data { get; set; }
    }

    public partial class ERC20WithdrawalFinalizedEventDTO : ERC20WithdrawalFinalizedEventDTOBase { }

    [Event("ERC20WithdrawalFinalized")]
    public class ERC20WithdrawalFinalizedEventDTOBase : IEventDTO
    {
        [Parameter("address", "_l1Token", 1, true)]
        public virtual string L1Token { get; set; }
        [Parameter("address", "_l2Token", 2, true)]
        public virtual string L2Token { get; set; }
        [Parameter("address", "_from", 3, true)]
        public virtual string From { get; set; }
        [Parameter("address", "_to", 4, false)]
        public virtual string To { get; set; }
        [Parameter("uint256", "_amount", 5, false)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("bytes", "_data", 6, false)]
        public virtual byte[] Data { get; set; }
    }

    public partial class ETHDepositInitiatedEventDTO : ETHDepositInitiatedEventDTOBase { }

    [Event("ETHDepositInitiated")]
    public class ETHDepositInitiatedEventDTOBase : IEventDTO
    {
        [Parameter("address", "_from", 1, true)]
        public virtual string From { get; set; }
        [Parameter("address", "_to", 2, true)]
        public virtual string To { get; set; }
        [Parameter("uint256", "_amount", 3, false)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("bytes", "_data", 4, false)]
        public virtual byte[] Data { get; set; }
    }

    public partial class ETHWithdrawalFinalizedEventDTO : ETHWithdrawalFinalizedEventDTOBase { }

    [Event("ETHWithdrawalFinalized")]
    public class ETHWithdrawalFinalizedEventDTOBase : IEventDTO
    {
        [Parameter("address", "_from", 1, true)]
        public virtual string From { get; set; }
        [Parameter("address", "_to", 2, true)]
        public virtual string To { get; set; }
        [Parameter("uint256", "_amount", 3, false)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("bytes", "_data", 4, false)]
        public virtual byte[] Data { get; set; }
    }









    public partial class DepositsOutputDTO : DepositsOutputDTOBase { }

    [FunctionOutput]
    public class DepositsOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }









    public partial class L2TokenBridgeOutputDTO : L2TokenBridgeOutputDTOBase { }

    [FunctionOutput]
    public class L2TokenBridgeOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class MessengerOutputDTO : MessengerOutputDTOBase { }

    [FunctionOutput]
    public class MessengerOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }
}