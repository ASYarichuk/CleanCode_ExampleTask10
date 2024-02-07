class Weapon
{
    private int _bullets;
    private int _minAmountBullets = 0;
    private int _costOfShot = 1;

    public bool CanShoot() => _bullets > _minAmountBullets;

    public void Shoot() => _bullets -= _costOfShot;
}