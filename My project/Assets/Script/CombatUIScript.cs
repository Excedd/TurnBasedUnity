using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Paneles de UI
    public GameObject actionPanel;
    public GameObject skillsPanel;

    // Botones de acciones
    public Button attackButton;
    public Button defendButton;
    public Button runButton;

    [SerializeField]
    public GameObject prefabButton;

    void Start()
    {
        // Inicialmente, solo el panel de acciones está activo
        actionPanel.SetActive(true);
        skillsPanel.SetActive(false);

        // Asignar funciones a los botones
        attackButton.onClick.AddListener(OnAttackButton);
        defendButton.onClick.AddListener(OnDefendButton);
        runButton.onClick.AddListener(OnRunButton);
    }

    // Función que se llama cuando presionas "Atacar"
    void OnAttackButton()
    {
        // Ocultar panel de acciones y mostrar habilidades
        actionPanel.SetActive(false);
        skillsPanel.SetActive(true);

        // Cargar las habilidades del personaje actual
        LoadSkillsForCharacter();
    }

    void OnDefendButton()
    {
        // Implementa lo que sucede al defender
    }

    void OnRunButton()
    {
        // Implementa lo que sucede al huir
    }

    // Aquí cargarías las habilidades del personaje que está en turno
    void LoadSkillsForCharacter()
    {
        // Aquí puedes acceder a las habilidades del personaje actual
        // Y asignarlas a los botones de skill (esto es un ejemplo)
        skill1Button.GetComponentInChildren<Text>().text = "Skill 1";
        skill2Button.GetComponentInChildren<Text>().text = "Skill 2";
        skill3Button.GetComponentInChildren<Text>().text = "Skill 3";

        // Asigna los listeners para los botones de habilidades
        skill1Button.onClick.AddListener(() => UseSkill(1));
        skill2Button.onClick.AddListener(() => UseSkill(2));
        skill3Button.onClick.AddListener(() => UseSkill(3));
    }

    void UseSkill(int skillId)
    {
        // Implementa lo que hace cada habilidad
        Debug.Log("Usaste la habilidad: " + skillId);
    }
}
