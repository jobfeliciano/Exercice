using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Mouvement_Vaisseau : MonoBehaviour
{
    [SerializeField] private float _acceleration = 15f;
    [SerializeField] private float _maxSpeed = 7f;
    [SerializeField] private float _rotationSpeed = 45f;

    [SerializeField] private Rigidbody2D _rigidbody;
    private Vector3 _rotationVector;
    [SerializeField]  private float _speed = 0f;
    [SerializeField] private bool _drift;

    [SerializeField] private GameObject _prefab;
    [SerializeField] private GameObject _shield;
    [SerializeField] private GameObject _explosion;
    [SerializeField] private GameObject _propulseur;


    [SerializeField] private Text _vies;
    [SerializeField] private GameObject _victoire;
    [SerializeField] private GameObject _defaite;
    [SerializeField] private GameObject _imgBonus;
    private float _nbVies = 3;
    private float _nbProjectile = 1;
    private float _shieldTimer;

    private float _propulseurTimer;
    private float _propulseurTimer2;

    [SerializeField] private ShieldLookAt _shieldLookAt;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _imgBonus.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        _propulseurTimer += Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, _rotationSpeed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-new Vector3(0, 0, _rotationSpeed) * Time.deltaTime);
        }

        if (_drift)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                _rigidbody.velocity += new Vector2(transform.up.x, transform.up.y) * _acceleration * Time.deltaTime;
            }



            if (Input.GetKey(KeyCode.DownArrow))
            {
                _rigidbody.velocity -= _rigidbody.velocity.normalized * _acceleration * Time.deltaTime;
            }
        }
        
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                _speed += _acceleration * Time.deltaTime;
                if (_speed > _maxSpeed)
                {
                    _speed = _maxSpeed;
                }

                _propulseur.SetActive(true);

                _propulseurTimer = 0;
                _propulseur.transform.localScale += new Vector3(0.50f, 0.50f, 0) * Time.deltaTime;

            }

            else if (_propulseurTimer >= 1)
            {
                _propulseur.SetActive(false);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                _speed -= _acceleration * Time.deltaTime;
                if (_speed < 0)
                {
                    _speed = 0;
                }               
                _propulseur.SetActive(true);
                _propulseurTimer2 = 0;
                _propulseur.transform.localScale -= new Vector3(0.70f, 0.70f, 0) * Time.deltaTime;
            }

            else if (_propulseurTimer2 >= 1)
            {
                _propulseur.SetActive(false);
            }

            _rigidbody.velocity = transform.up * _speed;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(_nbProjectile == 1) {
                GameObject newGameObject = Instantiate(_prefab, transform.position, transform.rotation);
                newGameObject.GetComponent<Laser>().InitializeVelocity();
            }
            else if (_nbProjectile == 2)
            {
                GameObject newGameObject1 = Instantiate(_prefab, transform.position + new Vector3(0, -0.5f, 0), transform.rotation);
                GameObject newGameObject2 = Instantiate(_prefab, transform.position + new Vector3(0, 0.5f, 0), transform.rotation);
                newGameObject1.GetComponent<Laser>().InitializeVelocity();
                newGameObject2.GetComponent<Laser>().InitializeVelocity();
            }

        }

        _shieldTimer += Time.deltaTime;
        if(_shield.activeInHierarchy)
            _shieldLookAt.GetComponent<ShieldLookAt>().ShieldFadeOut(_shieldTimer);
        if (_shieldTimer > 5)
            _shield.SetActive(false);

        if ((_defaite.activeInHierarchy))
            gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.gameObject.name.Equals("Bonus_Coeur(Clone)"))
            {
                _nbVies++;
                _vies.text = _nbVies.ToString();
            }
       else if (collision.gameObject.name.Equals("Bonus_Projectile(Clone)"))
            {
                _nbProjectile = 2;
                _imgBonus.SetActive(true);
            }
        else if (collision.gameObject.name.Equals("Collider"))
        {
            _nbProjectile = 2;
            _imgBonus.SetActive(true);
        }

        else
        {
            _nbVies--;
            _nbProjectile = 1;
            _imgBonus.SetActive(false);

            _shieldTimer = 0;
            _shield.SetActive(true);
            _shieldLookAt.GetComponent<ShieldLookAt>().LookAt(collision.transform);

            if (_nbVies <= 0)
            {
                _nbVies = 0;     
                GameObject newObject = Instantiate(_explosion, transform.position, transform.rotation);
                Destroy(newObject, 3);
                Destroy(gameObject);
                _defaite.SetActive(true);
                _victoire.SetActive(false);
            }
            _vies.text = _nbVies.ToString();
        }


    }
}
