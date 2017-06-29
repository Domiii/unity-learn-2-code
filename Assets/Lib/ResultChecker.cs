using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResultChecker : MonoBehaviour {
	public InputField input;

	public Image resultBackground;
	public Text resultText;

	public Color rightColor;
	public Color wrongColor;

	string encryptedCorrectPassword = "7E2+SSBRSLaw/2qYMZ0jcUP2yBk62z/kw+bLIexy7VNXk5tqUI4c59NHklGwjtOEwJ4zYuyABnapov1xZ5VPMmtPwxo56aybu0uxWwAFS3kaVUbhjHTL5JRT7o7SoCZfPRm3qJjfg0OixBtl7x19OiJIYYaEMdAJZtymZqevPuXZl9nEOyssmMZy76ljhma31Eu+NkBMmCSPQvlqKPDapSSzc82DfCw98HdxUCEpEzSQ8UvFX75bj7pOj7MLc4K2qfbYF8ZepxkBPwrNpAYR7YodPoOt5cd0XHwpeqsqc0cdD9KTVK0D8RFdN8qWN4L6yLnSvq3ES8COirZoBlgmow==";
	string publicKey = "ni hao 123!";

	void Start() {
		resultText.enabled = false;
	}

	public void CheckResult() {
		resultText.enabled = true;

		var inputPassword = input.text;
		var encryptedInputPassword = StringEncrpyt.Hash (inputPassword, publicKey);

		print (encryptedInputPassword);

		if (encryptedInputPassword != encryptedCorrectPassword) {
			// wrong!
			resultBackground.color = wrongColor;
			resultText.text = "That is wrong! :(";
		} else {
			// correct!
			resultBackground.color = rightColor;
			resultText.text = "That is correct! :D :D :D";
		}
	}
}
